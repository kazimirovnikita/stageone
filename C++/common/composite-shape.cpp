#include "composite-shape.hpp"
#include <iostream>
#include <stdexcept>
#include <algorithm>
#include <memory>
#include "matrix.hpp"
#include "breaking-up-on-layers.hpp"
#include "base-types.hpp"


kazimirov::CompositeShape::CompositeShape() :
  size_(0),
  shapes_(nullptr)
{}

kazimirov::CompositeShape::CompositeShape(const CompositeShape& other) :
  size_(other.size_),
  shapes_(nullptr)
{
  if (other.size_)
  {
    shapes_ =std::make_unique<Ptr[]>(size_);
    for (size_t i = 0; i < size_; i++)
    {
      shapes_[i] = other.shapes_[i];
    }
  }
}

kazimirov::CompositeShape::CompositeShape(CompositeShape&& other) :
  size_(other.size_),
  shapes_(std::move(other.shapes_))
{
  other.size_ = 0;
}

kazimirov::CompositeShape& kazimirov::CompositeShape::operator=(const CompositeShape& other)
{
  if (&other == this)
  {
    return *this;
  }
  if (other.size_ == 0)
  {
    size_ = 0;
    shapes_ = nullptr;
    return *this;
  }
  std::unique_ptr<Shape::Ptr[]> shapes = std::make_unique<Ptr[]>(other.size_);
  size_ = other.size_;
  for (size_t i = 0; i < other.size_; i++)
  {
    shapes[i] = other.shapes_[i];
  }
  size_ = other.size_;
  shapes_ = std::move(shapes);
  return *this;
}

kazimirov::CompositeShape& kazimirov::CompositeShape::operator=(CompositeShape&& other)
{
  if (&other == this)
  {
      return *this;
  }
  size_ = other.size_;
  shapes_ = std::move(other.shapes_);
  other.size_ = 0;
  return *this;
}

size_t kazimirov::CompositeShape::getSize() const
{
  return size_;
}

double kazimirov::CompositeShape::getArea() const
{
  double area = 0.0;
  for (size_t i = 0; i < size_; i++)
  {
    area += shapes_[i]->getArea();
  }
  return area;
}

kazimirov::point_t kazimirov::CompositeShape::getPos() const
{
  return getFrameRect().pos;
}

void kazimirov::CompositeShape::move(const point_t& point)
{
  move(point.x - getFrameRect().pos.x, point.y - getFrameRect().pos.y);
}

void kazimirov::CompositeShape::move(const double dx, const double dy)
{
  for (size_t i = 0; i < size_; i++)
  {
    shapes_[i]->move(dx, dy);
  }
}

void kazimirov::CompositeShape::scale(const double coefficient)
{
  if (coefficient <= 0.0)
  {
    throw std::invalid_argument("Coefficient must be > 0");
  }
  const point_t newPos = getFrameRect().pos;
  for (size_t i = 0; i < size_; i++)
  {
    const double dx = newPos.x + coefficient * (shapes_[i]->getFrameRect().pos.x - newPos.x);
    const double dy = newPos.y + coefficient * (shapes_[i]->getFrameRect().pos.y - newPos.y);
    shapes_[i]->move({ dx, dy });
    shapes_[i]->scale(coefficient);
  }
}

kazimirov::CompositeShape::Ptr kazimirov::CompositeShape::operator[](const size_t index) const
{
  if (index >= size_)
  {
    throw std::out_of_range("Wrong index is out of range");
  }
  return shapes_[index];
}

kazimirov::rectangle_t kazimirov::CompositeShape::getFrameRect() const
{
  if (size_ == 0)
  {
    throw std::invalid_argument("CS is empty ");
  }
  rectangle_t rect = shapes_[0]->getFrameRect();
  double top = rect.pos.y + rect.height / 2.0;
  double base = rect.pos.y - rect.height / 2.0;
  double right = rect.pos.x + rect.width / 2.0;
  double left = rect.pos.x - rect.width / 2.0;
  for (size_t i = 0; i < size_; i++)
  {
    rect = shapes_[i]->getFrameRect();
    top = std::max(top, rect.pos.y + rect.height / 2.0);
    base = std::min(base, rect.pos.y - rect.height / 2.0);
    right = std::max(right, rect.pos.x + rect.width / 2.0);
    left = std::min(left, rect.pos.x - rect.width / 2.0);
  }
  return rectangle_t{ (right - left), (top - base), {(right + left) / 2.0, (top + base) / 2.0} };
}

void kazimirov::CompositeShape::insertShape(const std::shared_ptr<Shape>& shape)
{
  if (shape == nullptr)
  {
    throw std::invalid_argument("Shape is nullptr");
  }
  std::unique_ptr<Shape::Ptr[]> shapes = std::make_unique<Ptr[]>(size_ + 1);
  for (size_t i = 0; i < size_; i++)
  {
    shapes[i] = shapes_[i];
  }
  shapes_ = std::move(shapes);
  shapes_[size_] = shape;
  size_++;
}

void kazimirov::CompositeShape::rotate(double angle)
{
  const point_t pos = getPos();
  for (size_t i = 0; i < size_; i++)
  {
    shapes_[i]->move(details::rotatePoint(angle, pos, shapes_[i]->getPos()));
    shapes_[i]->rotate(angle);
  }
}

kazimirov::Matrix kazimirov::CompositeShape::getLayers() const
{
  return kazimirov::breakUpOnLayers(shapes_, size_);
}

void kazimirov::CompositeShape::deleteShape(const size_t index)
{
  if (index >= size_)
  {
    throw std::out_of_range("Wrong index");
  }
  for (size_t i = 0; i < size_ - 1; i++)
  {
    shapes_[i] = shapes_[i + 1];
  }
  shapes_[--size_].reset();
}

void kazimirov::CompositeShape::print() const
{
  for (size_t i = 0; i < size_; i++)
  {
    std::cout << "Shape " << i << "\n";
    shapes_[i]->print();
  }
}

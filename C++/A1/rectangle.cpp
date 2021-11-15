#include "rectangle.hpp"
#include <iostream>
#include <cassert>


Rectangle::Rectangle(const double width, const double height, const point_t& pos):
  width_(width),
  height_(height),
  pos_(pos)
{
  assert((width_ > 0.0) && (height_ > 0.0));
}

double Rectangle::getArea() const
{
  return width_ * height_;
}

rectangle_t Rectangle::getFrameRect() const
{
  return rectangle_t{ width_, height_, pos_ };
}

void Rectangle::move(const double dx, const double dy)
{
  pos_.x += dx;
  pos_.y += dy;
}

void Rectangle::move(const point_t& center)
{
  pos_ = center;
}

point_t Rectangle::getPos() const
{
  return point_t{ pos_.x, pos_.y };
}

void Rectangle::print() const
{
  std::cout << "Rectangle width: " << width_ << " " << "Rectangle height:" << height_ << "\n";
  Shape::print();
}

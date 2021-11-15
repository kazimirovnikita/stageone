#include "rectangle.hpp"
#include <iostream>
#include <stdexcept>
#include <algorithm>
#include <cmath>
#include "base-types.hpp"

kazimirov::Rectangle::Rectangle(const double width, const double height, const point_t& pos) :
  corners_{{pos.x + width / 2, pos.y - height / 2 }, { pos.x + width / 2, pos.y + height / 2 },
           {pos.x - width / 2, pos.y + height / 2}, { pos.x - width / 2, pos.y - height / 2 }}
{
  if (width <= 0)
  {
    throw std::invalid_argument("Width must be > 0");
  }
  if (height <= 0)
  {
    throw std::invalid_argument("Height must be > 0");
  }
}

double kazimirov::Rectangle::getArea() const
{
  return getHeight() * getWidth();
}

kazimirov::rectangle_t kazimirov::Rectangle::getFrameRect() const
{
  double maxX = corners_[0].x;
  double maxY = corners_[0].y;
  double minX = corners_[0].x;
  double minY = corners_[0].y;
  for (size_t i = 0; i < (sizeof(corners_) / sizeof(corners_[0])); i++)
  {
    maxX = std::max(maxX, corners_[i].x);
    minX = std::min(minX, corners_[i].x);
    maxY = std::max(maxY, corners_[i].y);
    minY = std::min(minY, corners_[i].y);
  }
  return rectangle_t{ maxX - minX, maxY - minY, {(maxX + minX) / 2, (maxY + minY) / 2} };
}

void kazimirov::Rectangle::move(const double dx, const double dy)
{
  for (size_t i = 0; i < (sizeof(corners_) / sizeof(corners_[0])); i++)
  {
    corners_[i].x += dx;
    corners_[i].y += dy;
  }
}

void kazimirov::Rectangle::move(const point_t& center)
{
  const point_t pos = getPos();
  move(center.x - pos.x, center.y - pos.y);
}

void kazimirov::Rectangle::scale(const double coefficient)
{
  if (coefficient <= 0)
  {
    throw std::invalid_argument("Coefficient must be > 0");
  }
  point_t pos = getPos();
  for (size_t i = 0; i < (sizeof(corners_) / sizeof(corners_[0])); i++)
  {
    corners_[i].x = pos.x + coefficient * (corners_[i].x - pos.x);
    corners_[i].y = pos.y + coefficient * (corners_[i].y - pos.y);
  }
}

kazimirov::point_t kazimirov::Rectangle::getPos() const
{
  return getFrameRect().pos;
}

double kazimirov::Rectangle::getWidth() const
{
  return std::sqrt(std::pow(corners_[0].x - corners_[3].x, 2) + std::pow(corners_[0].y - corners_[3].y, 2));
}

double kazimirov::Rectangle::getHeight() const
{
  return std::sqrt(std::pow(corners_[0].x - corners_[1].x, 2) + std::pow(corners_[0].y - corners_[1].y, 2));
}

void kazimirov::Rectangle::rotate(double angle)
{
  const point_t pos = getPos();
  for (size_t i = 0; i < (sizeof(corners_) / sizeof(corners_[0])); i++)
  {
    corners_[i] = kazimirov::details::rotatePoint(angle, pos, corners_[i]);
  }
}

void kazimirov::Rectangle::print() const
{
  std::cout << "Rectangle width: " << getWidth() << " " << "Rectangle height:" << getHeight() << "\n";
  Shape::print();
}

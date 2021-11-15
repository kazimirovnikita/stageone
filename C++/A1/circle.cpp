#include "circle.hpp"
#include <iostream>
#include <cassert>

#define _USE_MATH_DEFINES

#include <cmath>

Circle::Circle(const point_t& pos, const double radius):
  pos_(pos),
  radius_(radius)
{
  assert(radius_ > 0.0);
}

double Circle::getArea() const
{
  return radius_ * radius_ * M_PI;
}

rectangle_t Circle::getFrameRect() const
{
  return rectangle_t{ 2 * radius_, 2 * radius_, pos_ };
}

void Circle::move(const point_t& center)
{
  pos_ = center;
}

void Circle::move(const double dx, const double dy)
{
  pos_.x += dx;
  pos_.y += dy;
}

point_t Circle::getPos() const
{
  return point_t{ pos_.x, pos_.y };
}

void Circle::print() const
{
  std::cout << "Circle radius : " << radius_ << "\n";
  Shape::print();
}

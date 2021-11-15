#include "circle.hpp"
#include <iostream>
#include <stdexcept>

#define _USE_MATH_DEFINES

#include <cmath>
#include "base-types.hpp"

kazimirov::Circle::Circle(const point_t& pos, const double radius) :
  pos_(pos),
  radius_(radius)
{
  if (radius <= 0)
  {
    throw std::invalid_argument("Radius must be > 0");
  }
}

double kazimirov::Circle::getArea() const
{
  return radius_ * radius_ * M_PI;
}

kazimirov::rectangle_t kazimirov::Circle::getFrameRect() const
{
  return rectangle_t{ 2 * radius_, 2 * radius_, pos_ };
}

void kazimirov::Circle::move(const point_t& center)
{
  pos_ = center;
}

void kazimirov::Circle::move(const double dx, const double dy)
{
  pos_.x += dx;
  pos_.y += dy;
}

void kazimirov::Circle::scale(const double coefficient)
{
  if (coefficient <= 0)
  {
    throw std::invalid_argument("Coefficient must be > 0");
  }
  radius_ *= coefficient;
}

kazimirov::point_t kazimirov::Circle::getPos() const
{
  return point_t{ pos_.x, pos_.y };
}

void kazimirov::Circle::rotate(double )
{}

double kazimirov::Circle::getRadius() const
{
  return radius_;
}

void kazimirov::Circle::print() const
{
  std::cout << "Circle radius : " << radius_ << "\n";
  Shape::print();
}

#include "square.hpp"

#include <iostream>

const char* Square::type = "SQUARE";

Square::Square(const Point& point) :
  Shape(point)
{}

void Square::draw(std::ostream & out) const
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << type;
    Shape::draw(out);
  }
}

#include "circle.hpp"

#include <iostream>

const char* Circle::type = "CIRCLE";

Circle::Circle(const Point& point) :
  Shape(point)
{}

void Circle::draw(std::ostream& out) const
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << type;
    Shape::draw(out);
  }
}

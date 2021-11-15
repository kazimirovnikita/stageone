#include "triangle.hpp"

#include <iostream>

const char* Triangle::type = "TRIANGLE";

Triangle::Triangle(const Point& point) :
  Shape(point)
{}

void Triangle::draw(std::ostream & out) const
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << type;
    Shape::draw(out);
  }
}

#ifndef TRIANGLE_HPP
#define TRIANGLE_HPP

#include <iostream>
#include "shape.hpp"
#include "point.hpp"

class Triangle : public Shape
{
public:
  Triangle(const Point& point);
  void draw(std::ostream& out) const override;
  static const char* type;
};

#endif

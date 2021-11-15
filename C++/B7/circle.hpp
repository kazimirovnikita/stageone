#ifndef CIRCLE_HPP
#define CIRCLE_HPP

#include <iostream>
#include "shape.hpp"
#include "point.hpp"

class Circle : public Shape
{
public:
  Circle(const Point& point);
  void draw(std::ostream& out) const override;
  static const char* type;
};

#endif

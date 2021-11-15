#ifndef SQUARE_HPP
#define SQUARE_HPP

#include <iostream>
#include "shape.hpp"
#include "point.hpp"

class Square : public Shape
{
public:
  Square(const Point& point);
  void draw(std::ostream& out) const override;
  static const char* type;
};

#endif

#ifndef UTILITY_HPP
#define UTILITY_HPP

#include <iostream>
#include "shape.hpp"

class ShapesInfo
{
public:
  ShapesInfo();
  void operator()(const Shape& shape);
  friend std::ostream& operator<<(std::ostream& out, const ShapesInfo& info);
private:
  size_t countVertices;
  size_t countTriangles;
  size_t countSquares;
  size_t countRectangles;
};

#endif

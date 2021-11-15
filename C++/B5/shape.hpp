#ifndef SHAPE_HPP
#define SHAPE_HPP

#include <vector>
#include <iostream>
#include "point.hpp"

const size_t TRIANGLE_VERTICES = 3;
const size_t RECTANGLE_VERTICES = 4;
const size_t PENTAGON_VERTICES = 5;

enum ShapePriority
{
  TRIANGLE,
  SQUARE,
  RECTANGLE,
  OTHER
};

using Shape = std::vector<Point>;

std::istream& operator>>(std::istream& in, Shape& shape);
std::ostream& operator<<(std::ostream& out, const Shape& shape);

bool isTriangle(const Shape& shape);
double getSquareOfDistance(const Point& point1, const Point& point2);
bool isRectangle(const Shape& shape);
bool isSquare(const Shape& shape);
bool isPentagon(const Shape& shape);

ShapePriority getPriority(const Shape& shape);

#endif

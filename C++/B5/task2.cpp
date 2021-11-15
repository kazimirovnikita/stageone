#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>
#include <string>
#include <unordered_set>

#include "shape.hpp"
#include "point.hpp"
#include "utility.hpp"



void task2(std::istream& in, std::ostream& out)
{
  std::vector<Shape> shapes((std::istream_iterator<Shape>(in)), std::istream_iterator<Shape>());
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }

  ShapesInfo info = std::for_each(shapes.begin(), shapes.end(), ShapesInfo());
  out << info;

  shapes.erase(std::remove_if(shapes.begin(), shapes.end(),
      [](const Shape& shape) { return shape.size() == PENTAGON_VERTICES; }), shapes.end());

  std::vector<Point> points(shapes.size());
  std::transform(shapes.begin(), shapes.end(), points.begin(), [](const Shape& shape) { return shape[0]; });
  out << "Points: ";
  std::copy(points.begin(), points.end(), std::ostream_iterator<Point>(out, " "));

  std::sort(shapes.begin(), shapes.end(),
      [](const Shape& shape1, const Shape& shape2) { return getPriority(shape1) < getPriority(shape2); });
  out << '\n' << "Shapes: " << '\n';
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<Shape>(out, "\n"));
}

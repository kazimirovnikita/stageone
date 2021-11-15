#include <iostream>
#include <memory>
#include <vector>
#include <iterator>
#include <algorithm>

#include "shape.hpp"
#include "circle.hpp"
#include "triangle.hpp"
#include "square.hpp"

void task2(std::istream& in, std::ostream& out)
{
  std::vector<Shape::Ptr> shapes((std::istream_iterator<Shape::Ptr>(in)), std::istream_iterator<Shape::Ptr>());
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
  out << "Original:" << '\n';
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<std::shared_ptr<Shape>>(out));

  out << "Left-Right:" << '\n';
  std::sort(shapes.begin(), shapes.end(),
      [](Shape::Ptr shape1, Shape::Ptr shape2) { return shape1->isMoreLeft(shape2); });
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<std::shared_ptr<Shape>>(out));

  out << "Right-Left:" << '\n';
  std::sort(shapes.begin(), shapes.end(),
      [](Shape::Ptr shape1, Shape::Ptr shape2) { return !(shape1->isMoreLeft(shape2)); });
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<std::shared_ptr<Shape>>(out));

  out << "Top-Bottom:" << '\n';
  std::sort(shapes.begin(), shapes.end(),
      [](Shape::Ptr shape1, Shape::Ptr shape2) { return shape1->isUpper(shape2); });
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<std::shared_ptr<Shape>>(out));

  out << "Bottom-Top:" << '\n';
  std::sort(shapes.begin(), shapes.end(),
      [](Shape::Ptr shape1, Shape::Ptr shape2) { return !(shape1->isUpper(shape2)); });
  std::copy(shapes.begin(), shapes.end(), std::ostream_iterator<std::shared_ptr<Shape>>(out));
}

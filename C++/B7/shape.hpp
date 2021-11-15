#ifndef SHAPE_HPP
#define SHAPE_HPP

#include <memory>
#include <iostream>
#include <functional>
#include "point.hpp"

class Shape
{
public:
  using Ptr = std::shared_ptr<Shape>;

  Shape(const Point& point);
  virtual ~Shape() = default;
  bool isMoreLeft(const Ptr& dx) const;
  bool isUpper(const Ptr& dy) const;
  virtual void draw(std::ostream& out) const = 0;
protected:
  Point point_;
};

using CreatePtr = std::function<Shape::Ptr(const Point&)>;

std::istream& operator>>(std::istream& in, CreatePtr& makePtr);
std::istream& operator>>(std::istream& in, std::shared_ptr<Shape>& shape);
std::ostream& operator<<(std::ostream& out, const std::shared_ptr<Shape>& shape);

#endif

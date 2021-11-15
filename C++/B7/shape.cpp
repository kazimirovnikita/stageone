#include "shape.hpp"

#include <iostream>
#include <functional>
#include <unordered_map>
#include "reading-utility.hpp"
#include "point.hpp"
#include "circle.hpp"
#include "triangle.hpp"
#include "square.hpp"

Shape::Shape(const Point& point):
  point_(point)
{}

bool Shape::isMoreLeft(const Ptr& dx) const
{
  return point_.x < dx->point_.x;
}

bool Shape::isUpper(const Ptr& dy) const
{
  return point_.y > dy->point_.y;
}

void Shape::draw(std::ostream& out) const
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << point_ << '\n';
  }
}

template<typename Type>
Shape::Ptr CreateShapePtr(const Point& point)
{
  return std::make_shared<Type>(point);
}

std::istream& operator>>(std::istream& in, CreatePtr& makePtr)
{
  std::istream::sentry sentry(in);
  if (sentry)
  {
    StreamGuard stream(in);
    in >> std::noskipws;
    std::string type;
    while (isalpha(in.peek()))
    {
      type.push_back(in.get());
    }

    const std::unordered_map<std::string, CreatePtr> command
    {
      {Triangle::type, &CreateShapePtr<Triangle>},
      {Circle::type, &CreateShapePtr<Circle>},
      {Square::type, &CreateShapePtr<Square>},
    };

    auto it = command.find(type);
    if (it == command.end())
    {
      throw std::invalid_argument("Wrong data!!!");
    }
    else
    {
      makePtr = it->second;
    }
  }
  return in;
}

std::istream& operator>>(std::istream& in, std::shared_ptr<Shape>& shape)
{
  std::istream::sentry sentry(in);
  if (sentry)
  {
    StreamGuard stream(in);
    in >> std::noskipws;
    in >> std::ws;
    CreatePtr shapes;
    in >> shapes;
    if (in.fail())
    {
      return in;
    }
    Point point;
    in >> point;
    if (in.fail())
    {
      return in;
    }
    shape = shapes(point);
  }
  return in;
}

std::ostream& operator<<(std::ostream& out, const std::shared_ptr<Shape>& shape)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    shape->draw(out);
  }
  return out;
}

#include "shape.hpp"
#include <iostream>
#include <string>
#include <iterator>
#include <cmath>
#include "reading-utility.hpp"
#include "point.hpp"

const double EPS = 0.000001;

std::istream& operator>>(std::istream& in, Shape& shape)
{
  std::istream::sentry sentry(in);
  if (sentry)
  {
    StreamGuard stream(in);
    in >> std::noskipws;
    size_t countVertices;
    in >> std::ws >> countVertices;
    if (in.fail())
    {
      return in;
    }
    if (countVertices == 0)
    {
      in.setstate(std::ios::failbit);
      return in;
    }
    Shape temp;
    for (size_t i = 0; i < countVertices; i++)
    {
      Point point;
      in >> point;
      if (in.fail())
      {
        return in;
      }
      temp.push_back(point);
    }
    in >> skipSpaces;
    if (in.eof() || in.peek() == '\n')
    {
      shape = std::move(temp);
    }
    else
    {
      in.setstate(std::ios::failbit);
    }
  }
  return in;
}

std::ostream& operator<<(std::ostream& out, const Shape& shape)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << shape.size() << " ";
    std::copy(shape.begin(), shape.end(), std::ostream_iterator<Point>(out, " "));
  }
  return out;
}

bool isTriangle(const Shape& shape)
{
  return shape.size() == TRIANGLE_VERTICES;
}

double getSquareOfDistance(const Point& point1, const Point& point2)
{
  return std::pow((point1.x - point2.x), 2) + std::pow((point1.y - point2.y), 2);
}

bool isRectangle(const Shape& shape)
{
  if (shape.size() == RECTANGLE_VERTICES)
  {
    const double squareOfSide1 = getSquareOfDistance(shape[1], shape[2]);
    const double squareOfSide2 = getSquareOfDistance(shape[3], shape[0]);
    return std::abs(squareOfSide1 - squareOfSide2) < EPS;
  }
  return false;
}

bool isSquare(const Shape& shape)
{
  if (isRectangle(shape))
  {
    const double squareOfSide1 = getSquareOfDistance(shape[0], shape[1]);
    const double squareOfSide2 = getSquareOfDistance(shape[1], shape[2]);
    return std::abs(squareOfSide1 - squareOfSide2) < EPS;
  }
  return false;
}

bool isPentagon(const Shape& shape)
{
  return shape.size() == PENTAGON_VERTICES;
}

ShapePriority getPriority(const Shape& shape)
{
  if (shape.size() == TRIANGLE_VERTICES)
  {
    return ShapePriority::TRIANGLE;
  }
  if (isSquare(shape))
  {
    return ShapePriority::SQUARE;
  }
  if (isRectangle(shape))
  {
    return ShapePriority::RECTANGLE;
  }
  else
  {
    return ShapePriority::OTHER;
  }
}

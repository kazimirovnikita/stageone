#include "utility.hpp"
#include <iostream>
#include "shape.hpp"

ShapesInfo::ShapesInfo() :
  countVertices(0),
  countTriangles(0),
  countSquares(0),
  countRectangles(0)
{}

void ShapesInfo::operator()(const Shape& shape)
{
  countVertices += shape.size();
  if (isTriangle(shape))
  {
    countTriangles++;
  }
  else if (isRectangle(shape))
  {
    countRectangles++;
    if (isSquare(shape))
    {
      countSquares++;
    }
  }
}

std::ostream& operator<<(std::ostream& out, const ShapesInfo& info)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << "Vertices: " << info.countVertices << '\n'
        << "Triangles: " << info.countTriangles << '\n'
        << "Squares: " << info.countSquares << '\n'
        << "Rectangles: " << info.countRectangles << '\n';
  }
  return out;
}

#include "point.hpp"

#include <iostream>
#include "reading-utility.hpp"

std::istream& operator>>(std::istream& in, Point& point)
{
  std::istream::sentry sentry(in);
  if (sentry)
  {
    StreamGuard stream(in);
    in >> std::noskipws;
    char separator;
    in >> skipSpaces >> separator;
    if (in.fail())
    {
      return in;
    }
    if (separator != '(')
    {
      in.unget();
      in.setstate(std::ios::failbit);
      return in;
    }
    int x;
    in >> skipSpaces >> x;
    if (in.fail())
    {
      return in;
    }
    in >> skipSpaces >> separator;
    if (in.fail())
    {
      return in;
    }
    if (separator != ';')
    {
      in.unget();
      in.setstate(std::ios::failbit);
      return in;
    }
    int y;
    in >> skipSpaces >> y;
    if (in.fail())
    {
      return in;
    }
    in >> skipSpaces >> separator;
    if (in.fail())
    {
      return in;
    }
    if (separator != ')')
    {
      in.unget();
      in.setstate(std::ios::failbit);
      return in;
    }
    point = { x, y };
  }
  return in;
}

std::ostream& operator<<(std::ostream& out, const Point& point)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << '(' << point.x << ';' << point.y << ')';
  }
  return out;
}

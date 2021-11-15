#ifndef BASE_TYPES_HPP
#define BASE_TYPES_HPP

namespace kazimirov
{
  struct point_t
  {
    double x;
    double y;
  };

  struct rectangle_t
  {
    double width;
    double height;
    point_t pos;
  };

  namespace details
  {
    point_t rotatePoint(double angle, const point_t& center, const point_t& point);
    bool areIntersected(const rectangle_t& frameRect1, const rectangle_t& frameRect2);
  }
}

#endif

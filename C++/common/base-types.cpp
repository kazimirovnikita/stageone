#include "base-types.hpp"

#define _USE_MATH_DEFINES
#include <cmath>

kazimirov::point_t kazimirov::details::rotatePoint(double angle, const point_t& center, const point_t& point)
{
  const double sin = std::sin(M_PI * angle / 180);
  const double cos = std::cos(M_PI * angle / 180);
  const double pointX = center.x + (point.x - center.x) * cos - (point.y - center.y) * sin;
  const double pointY = center.y + (point.x - center.x) * sin + (point.y - center.y) * cos ;
  return { pointX, pointY };
}

bool kazimirov::details::areIntersected(const rectangle_t& frameRect1,const rectangle_t& frameRect2)
{
  return ((std::fabs(frameRect1.pos.x - frameRect2.pos.x) < ((frameRect1.width + frameRect2.width) / 2))
      && (std::fabs(frameRect1.pos.y - frameRect2.pos.y) < ((frameRect1.height + frameRect2.height) / 2)));
}

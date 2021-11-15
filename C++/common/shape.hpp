#ifndef SHAPE_HPP
#define SHAPE_HPP

#include <memory>

namespace kazimirov
{
  struct point_t;
  struct rectangle_t;

  class Shape
  {
  public:
    using Ptr = std::shared_ptr<Shape>;

    virtual ~Shape() = default;
    virtual double getArea() const = 0;
    virtual rectangle_t getFrameRect() const = 0;
    virtual void move(const point_t& center) = 0;
    virtual void move(const double x, const double y) = 0;
    virtual void scale(const double coefficient) = 0;
    virtual point_t getPos() const = 0;
    virtual void rotate(const double angle) = 0;
    virtual void print() const = 0;
  };
}

#endif

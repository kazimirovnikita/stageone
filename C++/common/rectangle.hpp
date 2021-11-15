#ifndef RECTANGLE_HPP
#define RECTANGLE_HPP

#include "shape.hpp"
#include "base-types.hpp"

namespace kazimirov
{
  class Rectangle : public Shape
  {
  public:
    Rectangle(const double width, const double height, const point_t& pos);
    double getArea() const override;
    rectangle_t getFrameRect() const override;
    void move(const double dx, const double dy) override;
    void move(const point_t& center) override;
    void scale(const double coefficient) override;
    point_t getPos() const override;
    double getWidth() const;
    double getHeight() const;
    void rotate(double angle) override;
    void print() const override;
  private:
    point_t corners_[4];
  };
}

#endif

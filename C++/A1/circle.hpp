#ifndef CIRCLE_HPP
#define CIRCLE_HPP

#include "shape.hpp"

class Circle : public Shape
{
public:
  Circle(const point_t& pos, const double radius);
  double getArea() const override;
  rectangle_t getFrameRect() const override;
  void move(const point_t& center) override;
  void move(const double dx, const double dy) override;
  point_t getPos() const override;
  void print() const override;
private:
  point_t pos_;
  double radius_;
};

#endif

#ifndef COMPOSITE_SHAPE_HPP
#define COMPOSITE_SHAPE_HPP

#include <memory>
#include "shape.hpp"

namespace kazimirov
{
  class Matrix;
  class CompositeShape : public Shape
  {
  public:
    CompositeShape();
    CompositeShape(const CompositeShape& other);
    CompositeShape(CompositeShape&& other);
    ~CompositeShape() = default;
    CompositeShape& operator=(const CompositeShape& other);
    CompositeShape& operator=(CompositeShape&& other);
    Ptr operator[](const size_t index) const;
    size_t getSize() const;
    double getArea() const override;
    rectangle_t getFrameRect() const override;
    point_t getPos() const override;
    void move(const double dx, const double dy) override;
    void move(const point_t& center) override;
    void scale(const double coefficient) override;
    void insertShape(const std::shared_ptr<Shape>& shape);
    void deleteShape(const size_t index);
    void rotate(double angle) override;
    void print() const override;
    Matrix getLayers() const;

  private:
    size_t size_;
    std::unique_ptr<Shape::Ptr[]> shapes_;
  };
}
#endif

#ifndef MATRIX_HPP
#define MATRIX_HPP

#include "shape.hpp"

namespace kazimirov
{
  class Matrix
  {
  public:
    class LayerConst
    {
    public:
      Shape::Ptr operator[](size_t index) const;
      size_t getSize() const;
    protected:
      size_t index_;
    private:
      friend Matrix;
      const Matrix* matrix_;
      LayerConst(const Matrix* matrix, size_t index);
    };
    class LayerNotConst : public LayerConst
    {
    public:
      void insertShape(const Shape::Ptr& shape);
    private:
      friend Matrix;
      Matrix* matrix_;
      LayerNotConst(Matrix* matrix, size_t index);

    };
    Matrix();
    Matrix(const Matrix& other);
    Matrix(Matrix&& other);
    ~Matrix() = default;
    Matrix& operator= (const Matrix& other);
    Matrix& operator= (Matrix&& other);
    LayerConst operator[] (size_t index) const;
    LayerNotConst operator[] (size_t index);
    size_t getCountLayers() const;
    void addLayer();
  private:
    size_t countLayers_;
    size_t countColumns_;
    std::unique_ptr<Shape::Ptr[]> shapes_;
    void addShape(const Shape::Ptr& shape, size_t index);
  };
}
#endif // !MATRIX_HPP

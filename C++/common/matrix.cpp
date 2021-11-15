#include "matrix.hpp"
#include <iostream>
#include <memory>
#include <stdexcept>
#include <cassert>
#include "base-types.hpp"
#include "shape.hpp"

kazimirov::Matrix::Matrix() :
  countLayers_(0),
  countColumns_(0),
  shapes_(nullptr)
{}

kazimirov::Matrix::Matrix(const Matrix& other) :
  countLayers_(other.countLayers_),
  countColumns_(other.countColumns_),
  shapes_(nullptr)
{
  if (other.countLayers_)
  {
    shapes_ = std::make_unique<Shape::Ptr[]>(other.countColumns_ * other.countLayers_);
    for (size_t i = 0; i < (countColumns_ * countLayers_); i++)
    {
      shapes_[i] = other.shapes_[i];
    }
  }
}

kazimirov::Matrix::Matrix(Matrix&& other) :
  countLayers_(other.countLayers_),
  countColumns_(other.countColumns_),
  shapes_(std::move(other.shapes_))
{
  other.countColumns_ = 0;
  other.countLayers_ = 0;
}

kazimirov::Matrix& kazimirov::Matrix::operator=(const Matrix& other)
{
  if (this == &other)
  {
    return *this;
  }
  std::unique_ptr<Shape::Ptr[]> temp = std::make_unique<Shape::Ptr[]>(other.countColumns_ * other.countLayers_);
  for (size_t i = 0; i < (other.countColumns_ * other.countLayers_); i++)
  {
    temp[i] = other.shapes_[i];
  }
  countLayers_ = other.countLayers_;
  countColumns_ = other.countColumns_;
  shapes_ = std::move(temp);
  return *this;
}

kazimirov::Matrix& kazimirov::Matrix::operator=(Matrix&& other)
{
  if (this == &other)
  {
    return *this;
  }
  countLayers_ = other.countLayers_;
  countColumns_ = other.countColumns_;
  shapes_ = std::move(other.shapes_);
  other.countColumns_ = 0;
  other.countLayers_ = 0;
  return *this;
}

kazimirov::Matrix::LayerConst kazimirov::Matrix::operator[](size_t index) const
{
  if (index >= countLayers_)
  {
    throw std::out_of_range("Index is out of range");
  }
  return LayerConst(this, index);
}

kazimirov::Matrix::LayerNotConst kazimirov::Matrix::operator[](size_t index)
{
  if (index >= countLayers_)
  {
    throw std::out_of_range("Index is out of range");
  }
  return LayerNotConst(this, index);
}

size_t kazimirov::Matrix::getCountLayers() const
{
  return countLayers_;
}

void kazimirov::Matrix::addLayer()
{
  if (countColumns_ == 0)
  {
    std::unique_ptr<Shape::Ptr[]> temp = std::make_unique<Shape::Ptr[]>((countColumns_ + 1) * (countLayers_ + 1));
    shapes_ = std::move(temp);
    countColumns_++;
    countLayers_++;
  }
  else
  {
    std::unique_ptr<Shape::Ptr[]> temp = std::make_unique<Shape::Ptr[]>(countColumns_ * (countLayers_ + 1));
    for (size_t i = 0; i < (countColumns_ * countLayers_); i++)
    {
      temp[i] = shapes_[i];
    }
    shapes_ = std::move(temp);
    countLayers_++;
  }
}

void kazimirov::Matrix::addShape(const Shape::Ptr& shape, size_t index)
{
  if (shape == nullptr)
  {
    throw std::invalid_argument("Shape is nullptr");
  }
  if (index >= countLayers_)
  {
    throw std::out_of_range("Layer is out of range");
  }
  for (size_t i = 0; i < countColumns_; i++)
  {
    if (!shapes_[index * countColumns_ + i])
    {
      shapes_[index * countColumns_ + i] = shape;
      return;
    }
  }
  std::unique_ptr<Shape::Ptr[]> temp = std::make_unique<Shape::Ptr[]>(countLayers_ * (countColumns_ + 1));
  for (size_t i = 0; i < countLayers_; i++)
  {
    for (size_t j = 0; j < countColumns_; j++)
    {
      temp[i * (countColumns_ + 1) + j] = shapes_[i * countColumns_ + j];
    }
  }
  temp[index * (countColumns_ + 1) + countColumns_ ] = shape;
  shapes_ = std::move(temp);
  countColumns_++;
}

kazimirov::Matrix::LayerConst::LayerConst(const Matrix* matrix, size_t index):
  index_(index),
  matrix_(matrix)
{
  assert(index < matrix_->countLayers_);
}

kazimirov::Shape::Ptr kazimirov::Matrix::LayerConst::operator[](size_t index) const
{
  if (index >= getSize())
  {
    throw std::out_of_range("Index is out of range");
  }
  return matrix_->shapes_[index_ * (matrix_->countColumns_) + index];
}

kazimirov::Matrix::LayerNotConst::LayerNotConst(Matrix* matrix, size_t index) :
  LayerConst(matrix, index),
  matrix_(matrix)
{}

void kazimirov::Matrix::LayerNotConst::insertShape(const Shape::Ptr& shape)
{
  matrix_->addShape(shape, index_);
}

size_t kazimirov::Matrix::LayerConst::getSize() const
{
  for (size_t i = 0; i < matrix_->countColumns_; i++)
  {
    if (!matrix_->shapes_[index_ * matrix_->countColumns_ + i])
    {
      return i;
     }
  }
  return matrix_->countColumns_;
}

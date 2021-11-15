#ifndef BREAKING_UP_ON_LAYERS
#define BREAKING_UP_ON_LAYERS

#include "matrix.hpp"
#include "shape.hpp"

namespace kazimirov
{
  Matrix breakUpOnLayers(const std::unique_ptr<Shape::Ptr[]>& shape, const size_t size);
}

#endif // !BREAKING_UP_ON_LAYERS

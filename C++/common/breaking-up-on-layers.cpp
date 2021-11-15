#include "breaking-up-on-layers.hpp"
#include "matrix.hpp"
#include "shape.hpp"
#include "base-types.hpp"

kazimirov::Matrix kazimirov::breakUpOnLayers(const std::unique_ptr<Shape::Ptr[]>& shape, const size_t size)
{
  Matrix matrix;
  if (size != 0)
  {
    bool areIntersected = 0;
    size_t layer = 0;
    matrix.addLayer();
    matrix[0].insertShape(shape[0]);
    for (size_t i = 1; i < size; i++)
    {
      for (size_t j = 0; j < matrix.getCountLayers(); j++)
      {
        for (size_t k = 0; k < matrix[j].getSize(); k++)
        {
          if (details::areIntersected(matrix[j][k]->getFrameRect(), shape[i]->getFrameRect()))
          {
            layer = j + 1;
            areIntersected = 1;
          }
        }
        if (!areIntersected)
        {
          matrix[j].insertShape(shape[i]);
        }
      }
      if (layer == matrix.getCountLayers())
      {
        matrix.addLayer();
      }
      matrix[layer].insertShape(shape[i]);
    }
  }
  return matrix;
}

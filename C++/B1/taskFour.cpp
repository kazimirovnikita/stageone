#include <stdexcept>
#include <cstdlib>
#include <functional>
#include <vector>
#include "utility.hpp"

void fillRandom(double* array, int size)
{
  if (array == nullptr)
  {
    throw std::invalid_argument("Wrong array");
  }
  if (size <= 0)
  {
      throw std::invalid_argument("Size must be > 0");
  }
  for (int i = 0; i < size; i++)
  {
    array[i] = (static_cast<double>(std::rand()) / RAND_MAX) * 2 - 1;
  }
}

void task4(std::function<bool(const double&, const double&)> comp, const size_t size)
{
  if (size == 0)
  {
    throw std::invalid_argument("Size must be > 0");
  }

  std::vector<double> vector(size);
  fillRandom(vector.data(), size);
  print(vector);
  sort<AccessByAt>(vector, comp);
  print(vector);
}

#include <algorithm>
#include <ostream>
#include <iterator>
#include "factorialcontainer.hpp"

void taskTwo(std::ostream& out)
{
  const int maxIndex = 11;
  FactorialContainer container(maxIndex);
  std::copy(container.begin(), container.end(), std::ostream_iterator<size_t>(out, " "));
  out << '\n';
  std::copy(container.rbegin(), container.rend(), std::ostream_iterator<size_t>(out, " "));
  out << '\n';
}

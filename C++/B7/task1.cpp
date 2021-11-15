#include <iostream>
#include <iterator>
#include <functional>
#include <algorithm>

#define _USE_MATH_DEFINES

#include <cmath>

void task1(std::istream& in, std::ostream& out)
{
  std::transform(std::istream_iterator<double>(in), std::istream_iterator<double>(), std::ostream_iterator<double>(out, " "), std::bind2nd(std::multiplies<double>(), M_PI));
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
}

#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>
#include <string>
#include <unordered_set>

#include "functor-info.hpp"



void task(std::istream& in, std::ostream& out)
{
  std::vector<long long int> data((std::istream_iterator<long long int>(in)), std::istream_iterator<long long int>());
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }

  FunctorInfo info = std::for_each(data.begin(), data.end(), FunctorInfo());
  out << info;
}

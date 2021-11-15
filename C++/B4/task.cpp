#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>

#include "data-struct.hpp"


void task(std::istream& in, std::ostream& out)
{
  std::vector<DataStruct> data((std::istream_iterator<DataStruct>(in)), std::istream_iterator<DataStruct>());
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
  std::sort(data.begin(), data.end());
  std::copy(data.begin(), data.end(), std::ostream_iterator<DataStruct>(out, "\n"));
}

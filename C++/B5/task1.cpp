#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>
#include <string>
#include <unordered_set>



void task1(std::istream& in, std::ostream& out)
{
  std::unordered_set<std::string> data((std::istream_iterator<std::string>(in)), std::istream_iterator<std::string>());
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
  std::copy(data.begin(), data.end(), std::ostream_iterator<std::string>(out, "\n"));
}

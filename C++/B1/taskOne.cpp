#include <vector>
#include <stdexcept>
#include <iostream>
#include <functional>
#include <forward_list>
#include "utility.hpp"

void task1(std::function<bool(const int&, const int&)> comp)
{
  std::vector<int> vector;
  int data = 0;

  while (std::cin >> data)
  {
    vector.push_back(data);
  }
  if (!std::cin.eof())
  {
    throw std::invalid_argument("Wrong parameter");
  }
  if (vector.empty())
  {
    return;
  }

  std::vector<int> vectorAt(vector);
  std::forward_list<int> list(vector.begin(), vector.end());

  sort<AccessByOperator>(vector, comp);
  print(vector);

  sort<AccessByAt>(vectorAt, comp);
  print(vectorAt);

  sort<AccessByIterator>(list, comp);
  print(list);
}

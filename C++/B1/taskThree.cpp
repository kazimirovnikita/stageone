#include <iostream>
#include <vector>
#include <stdexcept>
#include "utility.hpp"

void task3()
{
  std::vector<int> vector;
  int data = 0;

  while (std::cin >> data)
  {
    if (data == 0)
    {
      break;
    }
    vector.push_back(data);
  }
  if (!std::cin.eof() && std::cin.fail())
  {
    throw std::invalid_argument("Wrong input");
  }
  if (data != 0)
  {
    throw std::invalid_argument("Last data must be zero");
  }
  if (vector.empty())
  {
    return;
  }

  if (vector.back() == 1)
  {
    auto i = vector.begin();
    while (i != vector.end())
    {
      if (*i % 2 == 0)
      {
        i = vector.erase(i);
      }
      else
      {
        i++;
      }
    }
  }
  if (vector.back() == 2)
  {
    auto i = vector.begin();
    while (i != vector.end())
    {
      if (*i % 3 == 0)
      {
        i = vector.insert(i + 1, 3, 1) + 3;
      }
      else
      {
        i++;
      }
    }
  }
  print(vector);
}

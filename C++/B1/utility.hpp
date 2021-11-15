#ifndef UTILITY_HPP
#define UTILITY_HPP

#include <iostream>
#include <functional>
#include <stdexcept>
#include <cstring>
#include <algorithm>
#include "access.hpp"

template<typename ValueType>
std::function<bool(const ValueType&, const ValueType&)> determineOrder(const char* order)
{
  if (order == nullptr)
  {
    throw std::invalid_argument("Parametr missing");
  }
  if (!strcmp(order, "ascending"))
  {
    return std::less<const ValueType>();
  }
  if (!strcmp(order, "descending"))
  {
    return std::greater<const ValueType>();
  }
  throw std::invalid_argument("Wrong parameter");
}

template <template <typename> class Access, typename Container>
void sort(Container& container, std::function<bool(const typename Container::value_type, const typename Container::value_type)> comp)
{
  using TypeAccess = Access<Container>;

  for (auto i = TypeAccess::begin(container); i != TypeAccess::end(container); i++)
  {
    for (auto j = i; j != TypeAccess::end(container); j++)
    {
      if (comp(TypeAccess::get(container, j), TypeAccess::get(container, i)))
      {
        std::swap(TypeAccess::get(container, j), TypeAccess::get(container, i));
      }
    }
  }
};

template <typename Container>
void print(const Container& container)
{
  for (auto i = container.begin(); i != container.end(); i++)
  {
    std::cout << *i << " ";
  }
  std::cout << '\n';
};

#endif

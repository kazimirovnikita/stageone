#ifndef ACCESS_HPP
#define ACCESS_HPP

#include <stdexcept>

template <typename Container>
class AccessByOperator
{
public:
  using value = typename Container::value_type;
  using iterator = typename Container::size_type;

  static iterator begin(const Container&)
  {
    return 0;
  }
  static iterator end(const Container& container)
  {
    return container.size();
  }
  static value& get(Container& container, const size_t index)
  {
    if (index >= container.size())
    {
      throw std::out_of_range("Index is out of range");
    }
    return container[index];
  }
};

template <typename Container>
class AccessByAt
{
public:
  using value = typename Container::value_type;
  using iterator = typename Container::size_type;

  static iterator begin(const Container&)
  {
    return 0;
  }
  static iterator end(const Container& container)
  {
    return container.size();
  }
  static value& get(Container& container, const size_t index)
  {
    if (index >= container.size())
    {
      throw std::out_of_range("Index is out of range");
    }
    return container.at(index);
  }
};

template <typename Container>
class AccessByIterator
{
public:
  using value = typename Container::value_type;
  using iterator = typename Container::iterator;

  static iterator begin(Container& container)
  {
    return container.begin();
  }
  static iterator end(Container& container)
  {
    return container.end();
  }
  static value& get(Container&, iterator iterator)
  {
    return *iterator;
  }
};

#endif

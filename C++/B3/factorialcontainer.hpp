#ifndef FACTORIALCONTAINER_HPP
#define FACTORIALCONTAINER_HPP

#include <iterator>
#include <cstddef>

class FactorialContainer
{
public :

  class iterator : public std::iterator<std::bidirectional_iterator_tag, size_t, std::ptrdiff_t, size_t*, size_t>
  {
  public:
    iterator& operator++();
    iterator operator++(int);
    iterator& operator--();
    iterator operator--(int);

    size_t operator*() const;
    bool operator==(const iterator&) const;
    bool operator!=(const iterator&) const;

  private:
    iterator(const size_t endPos_, const size_t pos_, const size_t value);
    size_t endPos_;
    size_t pos_;
    size_t value_;
    friend FactorialContainer;
  };
  using const_iterator = iterator;
  using const_reverse_iterator = std::reverse_iterator<iterator>;

  FactorialContainer(size_t maxIndex = 0);
  const_iterator begin() const;
  const_iterator end() const;
  const_reverse_iterator rbegin() const;
  const_reverse_iterator rend() const;

  size_t getFactorial(const size_t number) const;

private :
  const size_t maxIndex_;
  const size_t maxValue_;
};

#endif

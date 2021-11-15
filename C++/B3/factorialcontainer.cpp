#include "factorialcontainer.hpp"

#include <cstddef>
#include <stdexcept>
#include <cassert>

FactorialContainer::iterator::iterator(const size_t endPos, const size_t pos, const size_t value) :
  endPos_(endPos),
  pos_(pos),
  value_(value)
{
  assert(pos <= endPos);
}

FactorialContainer::iterator& FactorialContainer::iterator::iterator::operator++()
{
  if (pos_ == endPos_)
  {
    throw std::out_of_range("Pos must be < endPos");
  }
  pos_++;
  value_ *= pos_;
  return *this;
}

FactorialContainer::iterator FactorialContainer::iterator::iterator::operator++(int)
{
  iterator it = *this;
  (it)++;
  return it;
}

FactorialContainer::iterator& FactorialContainer::iterator::iterator::operator--()
{
  if (pos_ == 1)
  {
    throw std::out_of_range("Pos must be > 1");
  }
  value_ /= pos_;
  pos_--;
  return *this;
}

FactorialContainer::iterator FactorialContainer::iterator::iterator::operator--(int)
{
  iterator it = *this;
  --(it);
  return it;
}

size_t FactorialContainer::iterator::iterator::operator*() const
{
  return value_;
}

bool FactorialContainer::iterator::iterator::operator==(const iterator& it) const
{
  return pos_ == it.pos_;
}

bool FactorialContainer::iterator::iterator::operator!=(const iterator& it) const
{
  return !(*this == it);
}

FactorialContainer::FactorialContainer(std::size_t maxIndex) :
  maxIndex_(maxIndex),
  maxValue_(getFactorial(maxIndex))
{}


FactorialContainer::const_iterator FactorialContainer::begin() const
{
  return iterator(maxIndex_, 1, 1);
}

FactorialContainer::const_iterator FactorialContainer::end() const
{
  return iterator(maxIndex_, maxIndex_, maxValue_);
}

FactorialContainer::const_reverse_iterator FactorialContainer::rbegin() const
{
  return const_reverse_iterator(end());
}

FactorialContainer::const_reverse_iterator FactorialContainer::rend() const
{
  return const_reverse_iterator(begin());
}

size_t FactorialContainer::getFactorial(const size_t number) const
{
  size_t result = 1;
  for (size_t i = 1; i <= number; i++)
  {
    if (result > (SIZE_MAX / i))
    {
      throw std::overflow_error("Result variable overflow");
    }
    result *= i;
  }
  return result;
}

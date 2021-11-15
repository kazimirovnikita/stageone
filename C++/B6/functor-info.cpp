#include "functor-info.hpp"
#include <iostream>
#include <climits>

FunctorInfo::FunctorInfo() :
  empty(true),
  first(0),
  count(0),
  max(LLONG_MIN),
  min(LLONG_MAX),
  positive(0),
  negative(0),
  oddSum(0),
  evenSum(0),
  equal(false)
{}

void FunctorInfo::operator()(const long long int& data)
{
  if (empty)
  {
    first = data;
    empty = false;
  }
  count++;
  if (max < data)
  {
    max = data;
  }
  if (min > data)
  {
    min = data;
  }
  if (data > 0)
  {
    positive++;
  }
  else if (data < 0)
  {
    negative++;
  }
  if (data % 2 != 0)
  {
    oddSum += data;
  }
  else
  {
    evenSum += data;
  }
  equal = (first == data);
}

std::ostream& operator<<(std::ostream& out, const FunctorInfo& info)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    if (info.empty)
    {
      out << "No Data" << '\n';
    }
    else
    {
      out << "Max: " << info.max << '\n'
          << "Min: " << info.min << '\n'
          << "Mean: " << (static_cast<double>(info.oddSum) + static_cast<double>(info.evenSum)) / info.count << '\n'
          << "Positive: " << info.positive << '\n'
          << "Negative: " << info.negative << '\n'
          << "Odd Sum: " << info.oddSum << '\n'
          << "Even Sum: " << info.evenSum << '\n'
          << "First/Last Equal: " << (info.equal ? "yes" : "no") << '\n';
    }
  }

  return out;
}

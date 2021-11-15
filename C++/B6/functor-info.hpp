#ifndef FUNCTOR_HPP
#define FUNCTOR_HPP

#include <iostream>


class FunctorInfo
{
public:
  FunctorInfo();
  void operator()(const long long int& data);
private:
  bool empty;
  long long int first;
  long long int count;
  long long int max;
  long long int min;
  long long int positive;
  long long int negative;
  long long int oddSum;
  long long int evenSum;
  bool equal;

  friend std::ostream& operator<<(std::ostream& out, const FunctorInfo& info);
};

#endif

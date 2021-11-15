#include <iostream>
#include <list>
#include <stdexcept>

void taskTwo(std::istream& in, std::ostream& out)
{
  std::list<int> list;
  const int minValue = 1;
  const int maxValue = 20;
  const int maxSize = 20;
  int data = 0;

  while (in >> data)
  {
    if ((data > maxValue) || (data < minValue))
    {
      throw std::invalid_argument("Data must be from 1-20");
    }
    if (list.size() + 1 > maxSize)
    {
      throw std::logic_error("Max size can not be > 20");
    }
    list.push_back(data);
  }
  if (!in.eof())
  {
    throw std::invalid_argument("Incorrect input data");
  }

  if (list.empty())
  {
    return;
  }
  std::list<int>::iterator begin = list.begin();
  std::list<int>::iterator end = list.end();
  end--;

  while (begin != end) 
  {
    out << *(begin++);
    if (begin == end)
    {
      out << " " << *begin << "\n";
      return;
    }
    out << " " << *(end--) << " ";
  }
  out << *begin << "\n";
}

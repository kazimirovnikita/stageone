#include "data-struct.hpp"
#include <iostream>
#include <string>
#include "reading-utility.hpp"

const int MAX_VALUE = 5;
const int MIN_VALUE = -5;

std::istream& operator>>(std::istream& in, DataStruct& data)
{
  in >> std::noskipws;
  int key1;
  in >> std::ws >> key1;
  if (in.fail())
  {
    return in;
  }
  if (key1 > MAX_VALUE || key1 < MIN_VALUE)
  {
    in.setstate(std::ios::failbit);
    return in;
  }
  char separator1;
  in >> skipSpaces >> separator1;
  if (in.fail())
  {
    return in;
  }
  if (separator1 != ',')
  {
    in.setstate(std::ios::failbit);
    return in;
  }
  int key2;
  in >> skipSpaces >> key2;
  if (in.fail())
  {
    return in;
  }
  if (key2 > MAX_VALUE || key2 < MIN_VALUE)
  {
    in.setstate(std::ios::failbit);
    return in;
  }
  char separator2;
  in >> skipSpaces >> separator2;
  if (in.fail())
  {
    if (in.eof())
    {
      in.clear(in.rdstate() & ~std::ios::eofbit);
    }
    return in;
  }
  if (separator2 != ',')
  {
    in.setstate(std::ios::failbit);
    return in;
  }
  std::string str;
  std::getline(in >> skipSpaces, str);
  if (in.fail())
  {
    return in;
  }
  if (str.empty())
  {
    in.setstate(std::ios::failbit);
    if (in.eof())
    {
      in.clear(in.rdstate() & ~std::ios::eofbit);
    }
    return in;
  }
  data = { key1, key2, str };
  return in;
}

std::ostream& operator<<(std::ostream& out, const DataStruct& data)
{
  std::ostream::sentry sentry(out);
  if (sentry)
  {
    out << data.key1 << ',' << data.key2 << ',' << data.str;
  }
  return out;
}

bool operator<(const DataStruct& data1, const DataStruct& data2)
{
  if (data1.key1 != data2.key1)
  {
    return data1.key1 < data2.key1;
  }
  if (data1.key2 != data2.key2)
  {
    return data1.key2 < data2.key2;
  }
  return data1.str.size() < data2.str.size();
}

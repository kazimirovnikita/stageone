#ifndef DATA_STRUCT_HPP
#define DATA_STRUCT_HPP

#include <string>
#include <iostream>

struct DataStruct
{
  int key1;
  int key2;
  std::string str;
};

std::istream& operator>>(std::istream& in, DataStruct& data);
std::ostream& operator<<(std::ostream& out, const DataStruct& data);
bool operator<(const DataStruct& data1, const DataStruct& data2);

#endif

#include <iostream>
#include <string>
#include <sstream>
#include "phonebook.hpp" 
#include "interface.hpp"
#include "parser.hpp"


void taskOne(std::istream& in, std::ostream& out)
{
  PhoneBookInterface phonebook;
  std::string string;
  while (std::getline(in, string))
  {
    std::istringstream stream(string);
    if ((stream >> std::ws).eof())
    {
      continue;
    }
    CommandType parser = parse(stream);
    parser(phonebook, out);
  }
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
}

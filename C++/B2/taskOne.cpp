#include <iostream>
#include <string>
#include <sstream>
#include "queue.hpp"
#include "parser.hpp"


void taskOne(std::istream& in, std::ostream& out)
{
  QueueWithPriority<std::string> queue;
  std::string string;
  while (std::getline(in, string))
  {
    std::istringstream stream(string);
    if ((stream >> std::ws).eof())
    {
      continue;
    }
    CommandType parser = parse(stream);
    parser(queue, out);
  }
  if (!in.eof())
  {
    throw std::runtime_error("Read error");
  }
}

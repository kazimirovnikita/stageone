#include "parser.hpp"
#include <iostream>
#include <sstream>
#include <stdexcept>
#include <unordered_map>
#include "commands.hpp"

CommandType parse(std::istringstream& stream)
{
  std::string operation;
  stream >> operation;
  if (stream.fail())
  {
    throw std::runtime_error("Incorrect input arguments");
  }
  const std::unordered_map<std::string, CommandType(*)(std::istringstream&)> command
  {
    {"add", &parseAdd},
    {"store", &parseStore},
    {"delete", &parseDelete},
    {"insert", &parseInsert},
    {"show", &parseShow},
    {"move", &parseMove},
  };

  auto it = command.find(operation);
  if (it == command.end())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  else
  {
    return it->second(stream);
  }
}

CommandType parseAdd(std::istringstream& stream)
{
  std::string name;
  std::string number;
  readNumber(stream, number);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  readName(stream, name);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  PhoneBook::contact_t contact{ name, number };
  return std::bind(&add, std::placeholders::_1, contact);
}

CommandType parseStore(std::istringstream& stream)
{
  std::string markName;
  std::string newMarkName;
  readMarkName(stream, markName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  readMarkName(stream, newMarkName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  return std::bind(&store, std::placeholders::_1, std::placeholders::_2, markName, newMarkName);
}

CommandType parseDelete(std::istringstream& stream)
{
  std::string markName;
  readMarkName(stream, markName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  return std::bind(&removeContact, std::placeholders::_1, std::placeholders::_2, markName);
}

CommandType parseInsert(std::istringstream& stream)
{
  std::string pos;
  std::string markName;
  std::string name;
  std::string number;
  stream >> pos;
  if (stream.fail())
  {
    throw std::runtime_error("Incorrect input arguments");
  }
  readMarkName(stream, markName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  readNumber(stream, number);
  if (stream.fail())
  {
      return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  readName(stream, name);
  if (stream.fail())
  {
   return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }

  PhoneBook::contact_t contact{ name, number };
  if (pos == "after")
  {
    return std::bind(&insertAfter, std::placeholders::_1, std::placeholders::_2, markName, contact);
  }
  else if (pos == "before")
  {
    return std::bind(&insertBefore, std::placeholders::_1, std::placeholders::_2, markName, contact);
  }
  else
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
}

CommandType parseShow(std::istringstream& stream)
{
  std::string markName;
  readMarkName(stream, markName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  return std::bind(&show, std::placeholders::_1, std::placeholders::_2, markName);
}

CommandType parseMove(std::istringstream& stream)
{
  std::string markName;
  std::string pos;
  readMarkName(stream, markName);
  if (stream.fail())
  {
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }
  stream >> pos;
  if (stream.fail())
  {
    throw std::runtime_error("Incorrect input arguments");
  }
  std::string rubbish;
  if (!(stream >> std::ws).eof())
  {
    std::getline(stream, rubbish);
    return std::bind(&printInvalidCommand, std::placeholders::_2);
  }

  if (pos == "first")
  {
    return std::bind(&movePos, std::placeholders::_1, std::placeholders::_2, markName, PhoneBookInterface::Position::FIRST);
  }
  else if (pos == "last")
  {
    return std::bind(&movePos, std::placeholders::_1, std::placeholders::_2, markName, PhoneBookInterface::Position::LAST);
  }
  else
  {
    char* end = nullptr;
    int step = std::strtol(pos.c_str(), &end, 10);
    if (pos.empty() || *end != '\0'
      || errno == ERANGE
      || errno == EINVAL
      || step == 0)
    {
      return std::bind(&printInvalidStep, std::placeholders::_2);
    }
    return std::bind(&moveStep, std::placeholders::_1, std::placeholders::_2, markName, step);
  }
}

void readNumber(std::istringstream& stream, std::string& number)
{
  stream >> std::ws;

  while (stream && !isspace(stream.peek()))
  {
    if (std::isdigit(stream.peek()))
    {
      number.push_back(stream.get());
    }
    else
    {
      stream.setstate(std::ios::failbit);
      return;
    }
  }
}

void readName(std::istringstream& stream, std::string& name)
{
  stream >> std::ws;
  if (stream.get() != '"')
  {
    stream.setstate(std::ios::failbit);
    return;
  }
  while (stream)
  {
    if (stream.peek() != '\\')
    {
      if (stream.peek() == '"')
      {
        stream.get();
        return;
      }
      name.push_back(stream.get());
    }
    else
    {
      stream.get();
      name.push_back(stream.get());
      if (stream.peek() == EOF)
      {
        stream.setstate(std::ios::failbit);
      }
    }
  }
}

void readMarkName(std::istringstream& stream, std::string& markName)
{
  stream >> std::ws;
  while (stream && !isspace(stream.peek()) && !stream.eof())
  {
    if (isalnum(stream.peek()) || stream.peek() == '-')
    {
      markName.push_back(stream.get());
    }
    else
    {
      stream.setstate(std::ios::failbit);
      return;
    }
  }
}

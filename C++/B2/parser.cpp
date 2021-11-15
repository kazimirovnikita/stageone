#include "parser.hpp"
#include <string>
#include <functional>
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
    {"get", &parseGet},
    {"accelerate", &parseAccelerate}
  };

  auto iterator = command.find(operation);
  if (iterator != command.end())
  {
    return iterator->second(stream);
  }
  return &printInvalidCommand;
}

CommandType parseAdd(std::istringstream& stream)
{
  std::string priority;
  std::string data;
  stream >> priority >> std::ws;
  if (stream.fail())
  {
    throw std::runtime_error("Incorrect input arguments");
  }
  if (priority.empty())
  {
    return &printInvalidCommand;
  }
  std::getline(stream, data);
  if (data.empty())
  {
    return &printInvalidCommand;
  }

  const std::unordered_map<std::string, QueuePriority::ElementPriority> priorities
  {
    {"low", QueuePriority::ElementPriority::LOW},
    {"normal", QueuePriority::ElementPriority::NORMAL},
    {"high", QueuePriority::ElementPriority::HIGH}
  };

  QueuePriority::ElementPriority priorElem;
  auto iterator = priorities.find(priority);
  if (iterator != priorities.end())
  {
    priorElem = iterator->second;
  }
  else
  {
    return &printInvalidCommand;
  }
  return std::bind(&add, std::placeholders::_1, std::placeholders::_2, priorElem, data);
}


CommandType parseGet(std::istringstream& stream)
{
  std::string string;
  stream >> string;
  if (string.empty())
  {
    return &get;
  }
  else
  {
    return &printInvalidCommand;
  }
}

CommandType parseAccelerate(std::istringstream& stream)
{
  std::string string;
  stream >> string;
  if (string.empty())
  {
    return &accelerate;
  }
  else
  {
    return &printInvalidCommand;
  }
}

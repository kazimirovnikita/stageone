#ifndef PARSER_HPP
#define PARSER_HPP

#include <string>
#include <functional>
#include <sstream>
#include "queue.hpp"

using CommandType = std::function<void(QueueWithPriority<std::string>&, std::ostream&)>;

CommandType parse(std::istringstream& stream);
CommandType parseAdd(std::istringstream& stream);
CommandType parseGet(std::istringstream& stream);
CommandType parseAccelerate(std::istringstream& stream);

#endif

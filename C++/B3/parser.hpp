#ifndef PARSER_HPP
#define PARSER_HPP

#include <string>
#include <functional>
#include <sstream>
#include "interface.hpp"

using CommandType = std::function<void(PhoneBookInterface&, std::ostream&)>;

CommandType parse(std::istringstream& stream);
CommandType parseAdd(std::istringstream& stream);
CommandType parseStore(std::istringstream& stream);
CommandType parseDelete(std::istringstream& stream);
CommandType parseInsert(std::istringstream& stream);
CommandType parseShow(std::istringstream& stream);
CommandType parseMove(std::istringstream& stream);

void readNumber(std::istringstream& stream, std::string& number);
void readName(std::istringstream& stream, std::string& name);
void readMarkName(std::istringstream& stream, std::string& markName);
#endif

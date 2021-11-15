#ifndef COMMANDS_HPP
#define COMMANDS_HPP

#include <iostream>
#include <string>
#include "queue.hpp"

using QueuePriority = QueueWithPriority<std::string>;

void add(QueuePriority& queue, std::ostream&, const QueuePriority::ElementPriority priority, const std::string& data);
void get(QueuePriority& queue, std::ostream& out);
void accelerate(QueuePriority& queue, std::ostream&);
void printInvalidCommand(QueuePriority&, std::ostream& out);

#endif

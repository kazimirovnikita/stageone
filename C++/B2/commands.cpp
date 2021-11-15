#include "commands.hpp"
#include <iostream>
#include <string>

void add(QueuePriority& queue, std::ostream&, const QueuePriority::ElementPriority priority, const std::string& data)
{
  queue.put(data, priority);
}

void get(QueuePriority& queue, std::ostream& out)
{
  if (queue.isEmpty())
  {
    out << "<EMPTY>" << "\n";
    return;
  }
  out << queue.get() << "\n";
  queue.removeFirst();
}

void accelerate(QueuePriority& queue, std::ostream&)
{
  queue.accelerate();
}

void printInvalidCommand(QueuePriority&, std::ostream& out)
{
  out << "<INVALID COMMAND>" << "\n";
}

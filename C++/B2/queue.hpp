#ifndef QUEUE_HPP
#define QUEUE_HPP

#include <list>
#include <stdexcept>

template <typename QueueElement>
class QueueWithPriority
{
public:
  enum ElementPriority
  {
    LOW,
    NORMAL,
    HIGH
  };
  void put(const QueueElement& element, ElementPriority priority);
  void removeFirst();
  QueueElement get();
  void accelerate();
  bool isEmpty() const;
private:
  std::list<QueueElement> queue[3];
};

template<typename QueueElement>
void QueueWithPriority<QueueElement>::put(const QueueElement& element, ElementPriority priority)
{
  if (priority < 0 || priority >= sizeof(queue) / sizeof(queue[0]))
  {
    throw std::invalid_argument("Wrong priority");
  }
  queue[priority].push_back(element);
}

template <typename QueueElement>
void QueueWithPriority<QueueElement>::removeFirst()
{
  for (size_t i = sizeof(queue) / sizeof(queue[0]) - 1; i >= 0; --i)
  {
    if (!queue[i].empty())
    {
      queue[i].pop_front();
      return;
    }
  }
  throw std::runtime_error("Empty queue");
}

template<typename QueueElement>
QueueElement QueueWithPriority<QueueElement>::get()
{
  for (size_t i = sizeof(queue) / sizeof(queue[0]) - 1; i >= 0; --i)
  {
    if (!queue[i].empty())
    {
      return queue[i].front();
    }
  }
  throw std::runtime_error("Empty queue");
}

template<typename QueueElement>
void QueueWithPriority<QueueElement>::accelerate()
{
  queue[2].splice(queue[2].end(), queue[0]);
}

template<typename QueueElement>
bool QueueWithPriority<QueueElement>::isEmpty() const
{
  for (size_t i = 0; i < sizeof(queue) / sizeof(queue[0]); ++i)
  {
    if (!queue[i].empty())
    {
      return false;
    }
  }
  return true;
}

#endif

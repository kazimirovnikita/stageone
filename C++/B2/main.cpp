#include <iostream>
#include <stdexcept>
#include <sstream>
#include "queue.hpp"

void taskOne(std::istream& in, std::ostream& out);
void taskTwo(std::istream& in, std::ostream& out);

int main(int argc, char* argv[])
{
  try
  {
    if (argc != 2)
    {
      std::cerr << "Incorrect input arguments!!!!!!" << "\n";
      return 1;
    }

    std::istringstream stream(argv[1]);
    size_t taskNumber = 0;
    stream >> taskNumber;
    if (!stream)
    {
      std::cerr << "Incorrect parametr";
      return 1;
    }
    switch (taskNumber)
    {
    case 1:
      try
      {
        taskOne(std::cin, std::cout);
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Incorrect parameter" << error.what();
        return 1;
      }
      catch (const std::runtime_error& error)
      {
        std::cerr << "Error: " << error.what();
        return 2;
      }
      break;

    case 2:
      try
      {
        taskTwo(std::cin, std::cout);
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Incorrect parameter" << error.what();
        return 1;
      }
      catch (const std::logic_error& error)
      {
        std::cerr << "Error: " << error.what();
        return 1;
      }
      break;

    default:
      std::cerr << "Incorrect number of task";
      return 1;
    }
  }
  catch (const std::exception& exception)
  {
    std::cerr << "Unexpected error " << exception.what();
    return 2;
  }
  return 0;
}

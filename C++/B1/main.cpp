#include <iostream>
#include <stdexcept>
#include <ctime>
#include <cstdlib>
#include <sstream>
#include "utility.hpp"

void task1(std::function<bool(const int&, const int&)> comp);
void task2(const char* fileName);
void task3();
void task4(std::function<bool(const double&, const double&)> comp, const size_t size);

int main(int argc, char* argv[])
{
  try
  {
    if ((argc < 2) || (argc > 4))
    {
      std::cerr << "Incorrect input arguments";
      return 1;
    }
    std::srand(static_cast<unsigned int>(std::time(0)));
    std::istringstream string(argv[1]);
    size_t taskNumber = 0;
    string >> taskNumber;
    if (!string)
    {
      std::cerr << "Incorrect parametr";
      return 1;
    }
    switch (taskNumber)
    {
      case 1:
      if (argc != 3)
      {
        std::cerr << "Incorrect input arguments";
        return 1;
      }
      try
      {
        auto order1 = determineOrder<int>(argv[2]);
        task1(order1);
      }
      catch (const std::out_of_range& error)
      {
        std::cerr << "Error: " << error.what();
        return 1;
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Wrong parameter " << error.what();
        return 1;
      }
      break;

      case 2:
      if (argc != 3)
      {
        std::cerr << "Incorrect input arguments";
        return 1;
      }
      try
      {
        task2(argv[2]);
      }
      catch (const std::bad_alloc& error)
      {
        std::cerr << "Allocation error" << "\n";
        return 2;
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Wrong parameter" << error.what();
        return 1;
      }
      break;

      case 3:
      if (argc != 2)
      {
        std::cerr << "Incorrect input arguments";
        return 1;
      }
      try
      {
        task3();
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Wrong parameter" << error.what();
        return 1;
      }
      break;

      case 4:
      if (argc != 4)
      {
        std::cerr << "Incorrect input arguments";
        return 1;
      }
      try
      {
        std::istringstream newString(argv[3]);
        size_t size = 0;
        newString >> size;
        if (!newString)
        {
            std::cerr << "Incorrect parametr";
            return 1;
        }
        auto order2 = determineOrder<double>(argv[2]);
        task4(order2, size);
      }
      catch (const std::out_of_range& error)
      {
        std::cerr << "Error: " << error.what();
        return 1;
      }
      catch (const std::invalid_argument& error)
      {
        std::cerr << "Wrong parameter" << error.what();
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

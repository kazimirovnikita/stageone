#include <fstream>
#include <memory>
#include <stdexcept>
#include <vector>
#include "utility.hpp"

void task2(const char* fileName)
{
  if (fileName == nullptr)
  {
    throw std::invalid_argument("Wrong file name");
  }

  std::ifstream file(fileName);
  if (!file)
  {
    throw std::invalid_argument("File not open");
  }
  if (file.eof())
  {
    throw std::invalid_argument("File is empty");
  }


  size_t size = 64;
  size_t memBlock = 0;
  std::unique_ptr<char[], decltype(&free)> arr(static_cast<char*>(malloc(size)), &free);
  if (!arr)
  {
    throw std::bad_alloc();
  }

  while (file)
  {
    file.read(&arr[memBlock], size - memBlock);
    memBlock += file.gcount();
    if (size == memBlock)
    {
      size *= 2;
      std::unique_ptr<char[], decltype(&free)> newArr(static_cast<char*>(realloc(arr.get(), size)), &free);
      if (!newArr)
      {
        throw std::bad_alloc();
      }
      std::swap(arr, newArr);
      newArr.release();
    }
  }

  std::vector<char> vector(arr.get(), arr.get() + memBlock);
  for (auto i = vector.begin(); i != vector.end(); i++)
  {
    std::cout << *i;
  }
}

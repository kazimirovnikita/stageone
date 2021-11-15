#include <iostream>
#include <stdexcept>
#include <sstream>

void task(std::istream& in, std::ostream& out);

int main()
{
  try
  {
    task(std::cin, std::cout);
  }
  catch (const std::runtime_error& error)
  {
    std::cerr << "Error: " << error.what();
    return 2;
  }
  catch (const std::exception& exception)
  {
    std::cerr << "Unexpected error " << exception.what();
    return 3;
  }

  return 0;
}

#include <iostream>
#include <stdexcept>
#include "circle.hpp"
#include "rectangle.hpp"
#include "base-types.hpp"


int main()
{
  try
  {
    kazimirov::Shape* figure = 0;
    const kazimirov::point_t point = { 1.0, 3.0 };
    try
    {
      kazimirov::Rectangle rectangle(0.3, 5.0, { 2.2, 4.4 });
      figure = &rectangle;
      std::cout << "Rectangle created" << "\n";
      figure->print();

      figure->move(2.2, 3.7);
      std::cout << "Rectangle after first transfer " << "\n";
      figure->print();

      figure->move(point);
      std::cout << "Rectangle after second transfer " << "\n";
      figure->print();

      figure->scale(2.5);
      std::cout << "Rectangle after scaling " << "\n";
      figure->print();
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters" << error.what();
      return 1;
    }

    try
    {
      kazimirov::Circle circle({ 0.0, 0.0 }, 2.0);
      figure = &circle;
      std::cout << "Circle created" << "\n";
      figure->print();

      figure->move(-1.0, -2.5);
      std::cout << "Circle after first transfer " << "\n";
      figure->print();

      figure->move(point);
      std::cout << "Circle after second transfer " << "\n";
      figure->print();

      figure->scale(2.5);
      std::cout << "Circle after scaling " << "\n";
      figure->print();
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters" << error.what();
      return 1;
    }
  }
  catch (const std::invalid_argument& error)
  {
     std::cerr << "Error" << error.what();
     return 1;
  }
  return 0;
}

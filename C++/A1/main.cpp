#include <iostream>
#include "circle.hpp"
#include "rectangle.hpp"


int main()
{
  point_t point = { 1.0, 3.0 };

  Rectangle rectangle(0.3, 5.0, { 2.2, 4.4 });
  Shape* figure = &rectangle;
  std::cout << "Rectangle created" << "\n";
  figure->print();

  figure->move(2.2, 3.7);
  std::cout << "Rectangle after first transfer " << "\n";
  figure->print();

  figure->move(point);
  std::cout << "Rectangle after second transfer " << "\n";
  figure->print();

  Circle circle({ 0.0, 0.0 }, 2.0);
  figure = &circle;
  std::cout << "Circle created" << "\n";
  figure->print();

  figure->move(-1.0, -2.5);
  std::cout << "Circle after first transfer " << "\n";
  figure->print();

  figure->move(point);
  std::cout << "Circle after second transfer " << "\n";
  figure->print();

  return 0;
}

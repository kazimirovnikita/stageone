#include "shape.hpp"
#include <iostream>

void Shape::print() const
{
  std::cout << "Area is: " << getArea() << "\n";
  point_t pos = getPos();
  std::cout << "Pos x: " << pos.x << ", Pos y: " << pos.y << "\n";
  rectangle_t rect = getFrameRect();
  std::cout << "Frame rectangle:\n"
      << "Widht: " << rect.width << "\n"
      << "Height: " << rect.height << "\n"
      << "Pos x: " << rect.pos.x << ", Pos y: " << rect.pos.y << "\n";
}

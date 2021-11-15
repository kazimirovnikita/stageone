#include <iostream>
#include <memory>
#include "matrix.hpp"
#include "circle.hpp"
#include "rectangle.hpp"
#include "composite-shape.hpp"
#include "base-types.hpp"

int main()
{
  kazimirov::Matrix matrix;
  kazimirov::CompositeShape compShape;
  try
  {
    kazimirov::Shape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::point_t{ 0.0, 2.2 }, 5.0);
    kazimirov::Shape::Ptr rect = std::make_shared<kazimirov::Rectangle>(1.0, 2.1, kazimirov::point_t{ 0.1, 1.5 });
    kazimirov::Shape::Ptr rect1 = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(1.2, 2.5, kazimirov::point_t{ 50.0, 25.0 }));
    compShape.insertShape(rect);
    compShape.insertShape(circle);
    compShape.insertShape(rect1);
    try
    {
      matrix = compShape.getLayers();
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters: " << error.what();
      return 1;
    }
    std::cout << "Matrix of compositeShape:" << "\n";
    compShape.print();
    try
    {
      compShape.rotate(45);
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters: " << error.what();
      return 1;
    }
    std::cout << "CS after rotate:" << "\n";
    compShape.print();

    try
    {
      rect->rotate(25);
      rect1->rotate(45);
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters: " << error.what();
      return 1;
    }
    std::cout << "Rectangle after rotate:" << "\n";
    rect->print();

    try
    {
      circle->rotate(25);
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters: " << error.what();
      return 1;
    }
    std::cout << "Circle after rotate:" << "\n";
    circle->print();
  }
  catch (...)
  {
    std::cerr << "Unexpecter error: ";
    return 1;
  }
  return 0;
}

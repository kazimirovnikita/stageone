#include <iostream>
#include <memory>
#include "circle.hpp"
#include "rectangle.hpp"
#include "composite-shape.hpp"
#include "base-types.hpp"

int main()
{
  try
  {
    const kazimirov::point_t point{ 1.0, 3.3 };
    kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::point_t{ 0.0, 2.2 } , 5.0);
    kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(1.0, 2.1, kazimirov::point_t{ 0.1, 1.5 });
    kazimirov::CompositeShape compShape;
    try
    {
      compShape.insertShape(circle);
      compShape.insertShape(rect);
      std::cout << "Composite shape: " << "\n";
      compShape.print();

      compShape.move(2.2, 3.7);
      std::cout << "Composite shape after first transfer on axes: " << "\n";
      compShape.print();

      compShape.move(point);
      std::cout << "Composite shape after transfer on point: " << "\n";
      compShape.print();

      compShape.scale(2.5);
      std::cout << "Composite shape after scale: " << "\n";
      compShape.print();
    }
    catch (const std::invalid_argument& error)
    {
      std::cerr << "Wrong parameters: " << error.what();
      return 1;
    }
    catch (const std::out_of_range& error)
    {
      std::cerr << "Wrong index: " << error.what();
      return 1;
    }

  }
  catch (...)
  {
    std::cerr << "Unknown Error: ";
    return 1;
  }
  return 0;
}

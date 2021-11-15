#include <memory>
#include <boost/test/unit_test.hpp>
#include "breaking-up-on-layers.hpp"
#include "matrix.hpp"
#include "shape.hpp"
#include "composite-shape.hpp"
#include "circle.hpp"
#include "rectangle.hpp"
#include "base-types.hpp"


BOOST_AUTO_TEST_SUITE(Break_up_on_layers_test)

const double WIDTH1 = 22.0;
const double HEIGHT1 = 10.0;
const double RADIUS = 10.0;
const double WIDTH2 = 22.0;
const double HEIGHT2 = 10.0;
const kazimirov::point_t POSITION_R1 = { 2.2, 4.4 };
const kazimirov::point_t POSITION_R2 = { 50.0, 25.0 };
const kazimirov::point_t POSITION_C = { 2.5, 4.8 };

BOOST_AUTO_TEST_CASE(test_matrix_breaking_up_on_layers)
{
  kazimirov::Shape::Ptr rect = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH1, HEIGHT1, POSITION_R1));
  kazimirov::Shape::Ptr rect1 = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH2, HEIGHT2, POSITION_R2));
  kazimirov::Shape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::Circle(POSITION_C, RADIUS));
  std::unique_ptr<kazimirov::Shape::Ptr[]> arr = std::make_unique <kazimirov::Shape::Ptr[]>(3);
  arr[0] = circle;
  arr[1] =rect;
  arr[2] = rect1;
  kazimirov::Matrix  matrix;
  matrix = kazimirov::breakUpOnLayers(arr, 3);
  BOOST_CHECK_EQUAL(matrix[0][0], circle);
  BOOST_CHECK_EQUAL(matrix[1][1], rect1);
  BOOST_CHECK_EQUAL(matrix[1][0] , rect);
  BOOST_CHECK_EQUAL(matrix.getCountLayers(), 2);
}

BOOST_AUTO_TEST_SUITE_END()

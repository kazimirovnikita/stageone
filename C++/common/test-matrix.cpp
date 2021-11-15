#include <memory>
#include <stdexcept>
#include <boost/test/unit_test.hpp>
#include "matrix.hpp"
#include "composite-shape.hpp"
#include "rectangle.hpp"
#include "circle.hpp"
#include "base-types.hpp"

BOOST_AUTO_TEST_SUITE(Matrix_test)

const double WIDTH = 22.0;
const double HEIGHT = 10.0;
const double RADIUS = 10.0;
const kazimirov::point_t POSITION_R = { 2.2, 4.4 };
const kazimirov::point_t POSITION_C = { 2.5, 4.8 };

BOOST_AUTO_TEST_CASE(matrix_incorrect_index)
{
  kazimirov::Matrix matrix;
  BOOST_CHECK_THROW(matrix[0][1], std::out_of_range);
}

BOOST_AUTO_TEST_CASE(matrix_incorrect_insert_shape)
{
  kazimirov::Matrix matrix;
  matrix.addLayer();
  BOOST_CHECK_THROW(matrix[0].insertShape(nullptr), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(matrix_add_layer_test)
{
  kazimirov::Matrix matrix;
  matrix.addLayer();
  BOOST_CHECK_EQUAL(matrix.getCountLayers(), 1);
}

BOOST_AUTO_TEST_CASE(matrix_insert_test)
{
  kazimirov::Matrix matrix;
  kazimirov::Shape::Ptr rect = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH, HEIGHT, POSITION_R));
  kazimirov::Shape::Ptr rect1 = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH, HEIGHT, POSITION_R));
  kazimirov::Shape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::Circle( POSITION_C, RADIUS));
  matrix.addLayer();
  matrix[0].insertShape(circle);
  matrix[0].insertShape(rect);
  BOOST_CHECK_EQUAL(matrix[0][0], circle);
  BOOST_CHECK_EQUAL(matrix[0][1], rect);
  BOOST_CHECK(matrix.getCountLayers() == 1);
  BOOST_CHECK(matrix[0].getSize() == 2);
  matrix.addLayer();
  matrix[1].insertShape(rect1);
  BOOST_CHECK_EQUAL(matrix[1][0], rect1);
  BOOST_CHECK(matrix.getCountLayers() == 2);
}

BOOST_AUTO_TEST_CASE(matrix_empty_test)
{
  kazimirov::Matrix matrix;
  BOOST_CHECK_EQUAL(matrix.getCountLayers(), 0);
}

BOOST_AUTO_TEST_CASE(test_copy_constructor)
{
  kazimirov::Matrix matrix;
  kazimirov::Shape::Ptr rect = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH, HEIGHT, POSITION_R));
  kazimirov::Shape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::Circle(POSITION_C, RADIUS));

  matrix.addLayer();
  matrix[0].insertShape(rect);
  matrix[0].insertShape(circle);
  kazimirov::Matrix matrix1(matrix);
  BOOST_CHECK_EQUAL(matrix[0][0], matrix1[0][0]);
  BOOST_CHECK_EQUAL(matrix[0][1], matrix1[0][1]);
  BOOST_CHECK_EQUAL(matrix.getCountLayers(), matrix1.getCountLayers());
}

BOOST_AUTO_TEST_CASE(test_copy_operator)
{
  kazimirov::Matrix matrix;
  kazimirov::Shape::Ptr rect = std::make_shared<kazimirov::Rectangle>(kazimirov::Rectangle(WIDTH, HEIGHT, POSITION_R));
  kazimirov::Shape::Ptr circle = std::make_shared<kazimirov::Circle>(kazimirov::Circle(POSITION_C, RADIUS));

  matrix.addLayer();
  matrix[0].insertShape(circle);
  matrix[0].insertShape(rect);
  kazimirov::Matrix matrix1 = matrix;
  BOOST_CHECK_EQUAL(matrix[0][0], matrix1[0][0]);
  BOOST_CHECK_EQUAL(matrix[0][1], matrix1[0][1]);
  BOOST_CHECK_EQUAL(matrix.getCountLayers(), matrix1.getCountLayers());
}

BOOST_AUTO_TEST_SUITE_END()

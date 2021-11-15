#include <boost/test/unit_test.hpp>
#include <stdexcept>
#include <memory>
#include "composite-shape.hpp"
#include "circle.hpp"
#include "rectangle.hpp"
#include "base-types.hpp"

BOOST_AUTO_TEST_SUITE(Compoiste_shape_test)

const double EPS = 0.000001;
const double RADIUS = 10.0;
const double WIDTH = 22.0;
const double HEIGHT = 10.0;
const double DX = 6.0;
const double DY = 12.0;
const double COEFFICIENT = 2.0;
const kazimirov::point_t MOVE_POINT = { 6.8, 8.4 };
const kazimirov::point_t POSITION = { 2.3, 4.6 };
const kazimirov::point_t POSITION_R = { 2.2, 4.4 };
const kazimirov::point_t POSITION_C = { 2.5, 4.8 };

BOOST_AUTO_TEST_CASE(test_invald_coefficient)
{
  kazimirov::CompositeShape compShape;
  BOOST_CHECK_THROW(compShape.scale(-2.2), std::invalid_argument);
  BOOST_CHECK_THROW(compShape.scale(0), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_invald_composite_shape)
{
  kazimirov::CompositeShape compShape;
  BOOST_CHECK_THROW(compShape.getFrameRect(), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_insert_shape)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  BOOST_CHECK_THROW(compShape.insertShape(nullptr), std::invalid_argument);
  BOOST_CHECK(compShape[0] == circle);
  BOOST_CHECK(compShape[1] == rect);
  BOOST_CHECK(compShape.getSize() == 2);
}

BOOST_AUTO_TEST_CASE(test_delete_shape)
{
    kazimirov::CompositeShape compShape;
    kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
    kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
    compShape.insertShape(circle);
    compShape.insertShape(rect);
    compShape.deleteShape(0);
    BOOST_CHECK(compShape[0] == rect);
    BOOST_CHECK(compShape.getSize() == 1);
    BOOST_CHECK_THROW(compShape.deleteShape(1), std::out_of_range);
}

BOOST_AUTO_TEST_CASE(test_empty_shape)
{
  kazimirov::CompositeShape compShape;
  BOOST_CHECK(compShape.getArea() == 0);
  BOOST_CHECK(compShape.getSize() == 0);
}

BOOST_AUTO_TEST_CASE(test_copy_constructur)
{
  kazimirov::CompositeShape compShape_1;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape_1.insertShape(circle);
  compShape_1.insertShape(rect);
  kazimirov::CompositeShape compShape_2(compShape_1);
  BOOST_CHECK(compShape_1[0] == compShape_2[0]);
  BOOST_CHECK(compShape_1[1] == compShape_2[1]);
  BOOST_CHECK(compShape_1.getSize() == compShape_2.getSize());
}

BOOST_AUTO_TEST_CASE(test_operator_copy)
{
  kazimirov::CompositeShape compShape_1;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape_1.insertShape(circle);
  compShape_1.insertShape(rect);
  kazimirov::CompositeShape compShape_2 = compShape_1;

  BOOST_CHECK(compShape_1[0] == compShape_2[0]);
  BOOST_CHECK(compShape_1[1] == compShape_2[1]);
  BOOST_CHECK(compShape_1.getArea() == compShape_2.getArea());
  BOOST_CHECK(compShape_1.getSize() == compShape_2.getSize());
  BOOST_CHECK_CLOSE(compShape_1.getPos().x, compShape_2.getPos().x, EPS);
  BOOST_CHECK_CLOSE(compShape_1.getPos().y, compShape_2.getPos().y, EPS);
  BOOST_CHECK_CLOSE(compShape_1.getFrameRect().width, compShape_2.getFrameRect().width, EPS);
  BOOST_CHECK_CLOSE(compShape_1.getFrameRect().height, compShape_2.getFrameRect().height, EPS);
}

BOOST_AUTO_TEST_CASE(composite_shape_after_moving_axes)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  const double area = compShape.getArea();
  const double widht = compShape.getFrameRect().width;
  const double height = compShape.getFrameRect().height;
  kazimirov::rectangle_t frame_rect = compShape.getFrameRect();

  compShape.move(DX, DY);
  BOOST_CHECK_CLOSE(compShape.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.x, frame_rect.pos.x + DX, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.y, frame_rect.pos.y + DY, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().width, widht, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().height, height, EPS);
}

BOOST_AUTO_TEST_CASE(composite_shape_after_moving_point)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  const double area = compShape.getArea();
  const double widht = compShape.getFrameRect().width;
  const double height = compShape.getFrameRect().height;

  compShape.move(MOVE_POINT);
  BOOST_CHECK_CLOSE(compShape.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.x, MOVE_POINT.x, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.y, MOVE_POINT.y, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().width, widht, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().height, height, EPS);
}

BOOST_AUTO_TEST_CASE(composite_shape_after_scaling)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  double area = compShape.getArea();
  double posX = compShape.getPos().x;
  double posY = compShape.getPos().y;
  double circlePosX = compShape.getPos().x + COEFFICIENT * (POSITION_C.x - compShape.getPos().x);
  double circlePosY = compShape.getPos().y + COEFFICIENT * (POSITION_C.y - compShape.getPos().y);
  double rectPosX = compShape.getPos().x + COEFFICIENT * (POSITION_R.x - compShape.getPos().x);
  double rectPosY = compShape.getPos().y + COEFFICIENT * (POSITION_R.y - compShape.getPos().y);
  kazimirov::rectangle_t frame_rect = compShape.getFrameRect();

  compShape.scale(COEFFICIENT);
  BOOST_CHECK_CLOSE(area * COEFFICIENT * COEFFICIENT, compShape.getArea(), EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.x, posX, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.y, posY, EPS);
  BOOST_CHECK_CLOSE(compShape[0]->getPos().x, circlePosX, EPS);
  BOOST_CHECK_CLOSE(compShape[0]->getPos().y, circlePosY, EPS);
  BOOST_CHECK_CLOSE(compShape[1]->getPos().x, rectPosX, EPS);
  BOOST_CHECK_CLOSE(compShape[1]->getPos().y, rectPosY, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().width, frame_rect.width * COEFFICIENT,  EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().height, frame_rect.height * COEFFICIENT, EPS);
  BOOST_CHECK_CLOSE(compShape.getPos().x, posX, EPS);
  BOOST_CHECK_CLOSE(compShape.getPos().y, posY, EPS);
}

BOOST_AUTO_TEST_CASE(composite_shape_rotate_test)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  double area = compShape.getArea();
  double posX = compShape.getPos().x;
  double posY = compShape.getPos().y;
  kazimirov::rectangle_t frame_rect = compShape.getFrameRect();
  compShape.rotate(90);
  BOOST_CHECK_CLOSE(compShape.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().width, frame_rect.height, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().height, frame_rect.width, EPS);
  BOOST_CHECK_CLOSE(compShape.getPos().x, posX, EPS);
  BOOST_CHECK_CLOSE(compShape.getPos().y, posY, EPS);
}

BOOST_AUTO_TEST_CASE(shape_getters_work)
{
  kazimirov::CompositeShape compShape;
  kazimirov::CompositeShape::Ptr circle = std::make_shared<kazimirov::Circle>(POSITION_C, RADIUS);
  kazimirov::CompositeShape::Ptr rect = std::make_shared<kazimirov::Rectangle>(WIDTH, HEIGHT, POSITION_R);
  compShape.insertShape(circle);
  compShape.insertShape(rect);
  const double area = circle->getArea() + rect->getArea();
  const double width = compShape.getFrameRect().width;
  const double height = compShape.getFrameRect().height;
  const double posX = compShape.getPos().x;
  const double posY = compShape.getPos().y;

  BOOST_CHECK(compShape.getSize() == 2);
  BOOST_CHECK_CLOSE(compShape.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.x, posX, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().pos.y, posY, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().width, width, EPS);
  BOOST_CHECK_CLOSE(compShape.getFrameRect().height, height, EPS);
}
BOOST_AUTO_TEST_SUITE_END()

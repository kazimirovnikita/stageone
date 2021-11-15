#include <boost/test/unit_test.hpp>
#include <stdexcept>
#include "rectangle.hpp"
#include "base-types.hpp"

BOOST_AUTO_TEST_SUITE(Rectangle_test)

const double EPS = 0.000001;
const double WIDTH = 22.0;
const double HEIGHT = 10.0;
const double DX = 6.0;
const double DY = 12.0;
const double COEFFICIENT = 2.0;
const kazimirov::point_t POSITION = { 2.2, 4.4 };
const kazimirov::point_t MOVE_POINT = { 6.8, 8.4 };

BOOST_AUTO_TEST_CASE(test_inavald_width)
{
  BOOST_CHECK_THROW(kazimirov::Rectangle rect(-WIDTH, HEIGHT, POSITION), std::invalid_argument);
  BOOST_CHECK_THROW(kazimirov::Rectangle rect(0, HEIGHT, POSITION), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_inavald_height)
{
  BOOST_CHECK_THROW(kazimirov::Rectangle rect(WIDTH, -HEIGHT, POSITION), std::invalid_argument);
  BOOST_CHECK_THROW(kazimirov::Rectangle rect(WIDTH, 0, POSITION), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_invalid_coefficient)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  BOOST_CHECK_THROW(rect.scale(-COEFFICIENT), std::invalid_argument);
  BOOST_CHECK_THROW(rect.scale(0), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_permanence_after_moving_axes)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  const double width = rect.getWidth();
  const double height = rect.getHeight();
  const double area = rect.getArea();
  const double posX = rect.getPos().x;
  const double posY = rect.getPos().y;

  rect.move(DX, DY);
  BOOST_CHECK_CLOSE(rect.getWidth(), width, EPS);
  BOOST_CHECK_CLOSE(rect.getHeight(), height, EPS);
  BOOST_CHECK_CLOSE(rect.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().x, posX + DX, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().y, posY + DY, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.x, posX + DX, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.y, posY + DY, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().width, rect.getWidth(), EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().height, rect.getHeight(), EPS);
}

BOOST_AUTO_TEST_CASE(test_permanence_after_moving_point)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  const double width = rect.getWidth();
  const double height = rect.getHeight();
  const double area = rect.getArea();

  rect.move(MOVE_POINT);
  BOOST_CHECK_CLOSE(rect.getWidth(), width, EPS);
  BOOST_CHECK_CLOSE(rect.getHeight(), height, EPS);
  BOOST_CHECK_CLOSE(rect.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().x, MOVE_POINT.x, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().y, MOVE_POINT.y, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.x, MOVE_POINT.x, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.y, MOVE_POINT.y, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().width, WIDTH, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().height, HEIGHT, EPS);
}

BOOST_AUTO_TEST_CASE(test_after_scaling)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  const double area = rect.getArea();
  const double posX = rect.getPos().x;
  const double posY = rect.getPos().y;
  rect.scale(COEFFICIENT);

  BOOST_CHECK_CLOSE(area * COEFFICIENT * COEFFICIENT, rect.getArea(), EPS);
  BOOST_CHECK_CLOSE(POSITION.x, posX, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, posY, EPS);
  BOOST_CHECK_CLOSE(POSITION.x, rect.getFrameRect().pos.x, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, rect.getFrameRect().pos.y, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().width, WIDTH * COEFFICIENT, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().height, HEIGHT * COEFFICIENT, EPS);
  BOOST_CHECK_CLOSE(rect.getWidth(), WIDTH * COEFFICIENT, EPS);
  BOOST_CHECK_CLOSE(rect.getHeight(), HEIGHT * COEFFICIENT, EPS);
}

BOOST_AUTO_TEST_CASE(rectangle_rotate_check)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  const double posX = rect.getPos().x;
  const double posY = rect.getPos().y;

  rect.rotate(90);
  BOOST_CHECK_CLOSE(rect.getArea(), WIDTH * HEIGHT, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().width, HEIGHT, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().height, WIDTH, EPS);
  BOOST_CHECK_CLOSE(rect.getWidth(), WIDTH, EPS);
  BOOST_CHECK_CLOSE(rect.getHeight(), HEIGHT, EPS);
  BOOST_CHECK_CLOSE(POSITION.x, posX, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, posY, EPS);
  BOOST_CHECK_CLOSE(POSITION.x, rect.getFrameRect().pos.x, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, rect.getFrameRect().pos.y, EPS);
}

BOOST_AUTO_TEST_CASE(rectangle_getters_check)
{
  kazimirov::Rectangle rect(WIDTH, HEIGHT, POSITION);
  BOOST_CHECK_CLOSE(rect.getWidth(), WIDTH, EPS);
  BOOST_CHECK_CLOSE(rect.getHeight(), HEIGHT, EPS);
  BOOST_CHECK_CLOSE(rect.getArea(), WIDTH * HEIGHT, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().x, POSITION.x, EPS);
  BOOST_CHECK_CLOSE(rect.getPos().y, POSITION.y, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.x, POSITION.x, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().pos.y, POSITION.y, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().width, WIDTH, EPS);
  BOOST_CHECK_CLOSE(rect.getFrameRect().height, HEIGHT, EPS);
}

BOOST_AUTO_TEST_SUITE_END()

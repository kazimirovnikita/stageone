#include <boost/test/unit_test.hpp>

#define _USE_MATH_DEFINES

#include <cmath>
#include <stdexcept>
#include "circle.hpp"
#include "base-types.hpp"

BOOST_AUTO_TEST_SUITE(Circle_test)

const double RADIUS = 10.0;
const double DX = 4.0;
const double DY = 6.0;
const double COEFFICIENT = 1.5;
const double EPS = 0.000001;
const kazimirov::point_t POSITION = { 1.0, 3.0 };
const kazimirov::point_t MOVE_POINT = { 2.2, 6.3 };

BOOST_AUTO_TEST_CASE(test_invalid_radius)
{
  BOOST_CHECK_THROW(kazimirov::Circle circle(POSITION, -2.1), std::invalid_argument);
  BOOST_CHECK_THROW(kazimirov::Circle circle(POSITION, 0.0), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_invalid_coefficient)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  BOOST_CHECK_THROW(circle.scale(-COEFFICIENT), std::invalid_argument);
  BOOST_CHECK_THROW(circle.scale(0), std::invalid_argument);
}

BOOST_AUTO_TEST_CASE(test_permanence_after_moving_axes)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  const double radius = circle.getRadius();
  const double area = circle.getArea();
  const double posX = circle.getPos().x;
  const double posY = circle.getPos().y;


  circle.move(DX, DY);
  BOOST_CHECK_CLOSE(circle.getRadius(), radius, EPS);
  BOOST_CHECK_CLOSE(circle.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().x, posX + DX, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().y, posY + DY, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.x, posX + DX, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.y, posY + DY, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().width, 2 * RADIUS, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().height, 2 * RADIUS, EPS);
}

BOOST_AUTO_TEST_CASE(test_permanence_after_moving_point)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  const double radius = circle.getRadius();
  const double area = circle.getArea();

  circle.move(MOVE_POINT);
  BOOST_CHECK_CLOSE(circle.getRadius(), radius, EPS);
  BOOST_CHECK_CLOSE(circle.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().x, MOVE_POINT.x, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().y, MOVE_POINT.y, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.x, MOVE_POINT.x, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.y, MOVE_POINT.y, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().width, 2 * RADIUS, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().height, 2 * RADIUS, EPS);
}

BOOST_AUTO_TEST_CASE(test_after_scaling)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  const double area = circle.getArea();
  const double radius = circle.getRadius();
  const double posX = circle.getPos().x;
  const double posY = circle.getPos().y;
  circle.scale(COEFFICIENT);

  BOOST_CHECK_CLOSE(area * COEFFICIENT * COEFFICIENT, circle.getArea(), EPS);
  BOOST_CHECK_CLOSE(radius * COEFFICIENT, circle.getRadius(), EPS);
  BOOST_CHECK_CLOSE(POSITION.x, posX, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, posY, EPS);
  BOOST_CHECK_CLOSE(POSITION.x, circle.getFrameRect().pos.x, EPS);
  BOOST_CHECK_CLOSE(POSITION.y, circle.getFrameRect().pos.y, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().width, 2 * RADIUS * COEFFICIENT, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().height, 2 * RADIUS * COEFFICIENT, EPS);
}

BOOST_AUTO_TEST_CASE(circle_getters_check)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  BOOST_CHECK_CLOSE(circle.getRadius(), RADIUS, EPS);
  BOOST_CHECK_CLOSE(circle.getArea(), RADIUS * RADIUS * M_PI, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().x, POSITION.x, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().y, POSITION.y, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.x, POSITION.x, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.y, POSITION.y, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().height, 2 * RADIUS, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().width, 2 * RADIUS, EPS);
}

BOOST_AUTO_TEST_CASE(test_circle_rotate)
{
  kazimirov::Circle circle(POSITION, RADIUS);
  const double radius = circle.getRadius();
  const double area = circle.getArea();
  const double posX = circle.getPos().x;
  const double posY = circle.getPos().y;
  
  circle.rotate(38);
  BOOST_CHECK_CLOSE(circle.getRadius(), radius, EPS);
  BOOST_CHECK_CLOSE(circle.getArea(), area, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().x, posX, EPS);
  BOOST_CHECK_CLOSE(circle.getPos().y, posY, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.x, posX, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().pos.y, posY, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().width, 2 * RADIUS, EPS);
  BOOST_CHECK_CLOSE(circle.getFrameRect().height, 2 * RADIUS, EPS);
}

BOOST_AUTO_TEST_SUITE_END()

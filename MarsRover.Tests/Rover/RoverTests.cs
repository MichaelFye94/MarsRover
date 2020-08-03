using NUnit.Framework;
using System.Numerics;

namespace MarsRover.Tests
{
    [TestFixture]
    class RoverTests
    {
        private Rover _rover;

        [Test]
        public void TestRover_TurnLeft_HasHeading90DegreeLeftTurn()
        {
            _rover = new Rover((0, 0, "N"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("L");
            Assert.That(output, Is.EqualTo("0 0 W"));

            output = _rover.ProcessOrders("L");
            Assert.That(output, Is.EqualTo("0 0 S"));

            output = _rover.ProcessOrders("L");
            Assert.That(output, Is.EqualTo("0 0 E"));

            output = _rover.ProcessOrders("L");
            Assert.That(output, Is.EqualTo("0 0 N"));
        }

        [Test]
        public void TestRover_TurnRight_HasHeading90DegreeRightTurn()
        {
            _rover = new Rover((0, 0, "N"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("R");
            Assert.That(output, Is.EqualTo("0 0 E"));

            output = _rover.ProcessOrders("R");
            Assert.That(output, Is.EqualTo("0 0 S"));

            output = _rover.ProcessOrders("R");
            Assert.That(output, Is.EqualTo("0 0 W"));

            output = _rover.ProcessOrders("R");
            Assert.That(output, Is.EqualTo("0 0 N"));
        }

        [Test]
        public void TestRover_MoveToNorthOnce_HasPositionOneNorth()
        {
            _rover = new Rover((0, 0, "N"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("M");
            Assert.That(output, Is.EqualTo("0 1 N"));
        }

        [Test]
        public void TestRover_MoveOnEdge_DoesNotPassEdge()
        {
            _rover = new Rover((5, 5, "N"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("M");
            Assert.That(output, Is.EqualTo("5 5 N"));
        }

        [Test]
        public void TestRover_ExampleInput1_HasPosition13N()
        {
            _rover = new Rover((1, 2, "N"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("LMLMLMLMM");
            Assert.That(output, Is.EqualTo("1 3 N"));
        }

        [Test]
        public void TestRover_ExampleInput2_HasPosition51E()
        {
            _rover = new Rover((3, 3, "E"), new Vector2(5, 5));

            var output = _rover.ProcessOrders("MMRMMRMRRM");
            Assert.That(output, Is.EqualTo("5 1 E"));
        }
    }
}

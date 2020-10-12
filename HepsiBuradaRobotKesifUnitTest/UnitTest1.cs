using System;
using System.Collections.Generic;
using HepsiBuradaRobotKesif;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HepsiBuradaRobotKesifUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TEST1()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = DirectionEnum.N
            };

            var maksimumRobotAxis = new List<int>() { 5, 5 };
            var RobotMoves = "LMLMLMLMM";

            RobotMove robotMove = new RobotMove();
            robotMove.RobotMoving(maksimumRobotAxis, RobotMoves, position);

            var Output = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, Output);
        }
    }
}
public class UnitTest2
{
    [TestMethod]
    public void TEST2()
    {
        Position position = new Position()
        {
            X = 3,
            Y = 3,
            Direction = DirectionEnum.E
        };

        var maksimumRobotAxis = new List<int>() { 5, 5 };
        var RobotMoves = "LMLMLMLMM";

        RobotMove robotMove = new RobotMove();
        robotMove.RobotMoving(maksimumRobotAxis, RobotMoves, position);

        var Output = $"{position.X} {position.Y} {position.Direction.ToString()}";
        var expectedOutput = "5 1 E";

        Assert.AreEqual(expectedOutput, Output);
    }
}


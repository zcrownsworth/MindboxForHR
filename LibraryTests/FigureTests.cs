using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void GetTriangleAreaTest()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //Act
            Triangle triangle = new Triangle();
            double actual = triangle.GetTriangleArea(a, b, c);
            //Assert
            Assert.AreEqual(expected, actual,"OK");
        }
        [TestMethod()]
        public void GetCircleAreaTest()
        {
            //Arrange
            double radius = 3;
            double expected = 28.274333882308138;

            //Act
            Circle circle = new Circle();
            double actual = circle.GetCircleArea(radius);

            //Assert
            Assert.AreEqual(expected, actual, "OK");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CIV_UnitTesting_Exercises;

namespace ClassLibrary1
{
    [TestFixture]
    public class RecursiveCalculations
    {
        //Arrange

        RecursiveCalculations Tests;

        [SetUp]

        public void SetUp()
        {
            Tests = new RecursiveCalculations();
        }

        [Test]
        [TestCase(0, 1, 0, 1)]
        [TestCase(0, 1, 1, 2)]
        [TestCase(0, 1, 2, 3)]
        [TestCase(0, 1, 3, 5)]
        [TestCase(0, 1, 4, 8)]
        public void FibonacciRec(int num1, int num2, int numFibs, int expected)
        {
            //Act
            var Result = Tests.FibonacciRec(num1, num2, numFibs, expected);

            //Assert
            Assert.AreEqual(expected, Result);
        }

        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void FactorialRec(int input, int ans, int expected)
        {
            //Act
            var Result = Tests.FactorialRec(input, ans, expected);

            //Assert
            Assert.AreEqual(expected, Result);
        }
    }
}

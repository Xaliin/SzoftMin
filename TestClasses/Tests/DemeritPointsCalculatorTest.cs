using BeadandoFeladat2021.MainPrograms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Tests
{
    [TestFixture]
    public class DemeritPointsCalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(50, 0)]
        [TestCase(51, 0)]
        [TestCase(55, 0)]
        [TestCase(60, 1)]
        [TestCase(80, 3)]
        [TestCase(180, 13)]

        public void DemeritPointsCalculatorTest_CalculateDemeritPoints_ShouldReturnCorrectValue(int n, int expectedValue)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();
            //Act
            int actualValue = testObject.CalculateDemeritPoints(n);
            //Assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(181)]

        public void DemeritPointsCalculatorTest_CalculateDemeritPoints_ShouldThrowExceptionWhenGivenValueIsZeroOrLessOrAboveMaxSpeed(int n)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => testObject.CalculateDemeritPoints(n));
        }
    }
}

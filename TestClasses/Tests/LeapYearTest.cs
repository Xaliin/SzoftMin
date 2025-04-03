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
    public class LeapYearTest
    {
        [TestCase(2000, true)]
        [TestCase(4, true)]
        [TestCase(1600, true)]
        [TestCase(0, false)]
        [TestCase(-10, false)]
        [TestCase(2002, false)]
        [TestCase(1900, false)]
        [TestCase(2100, false)]

        public void LeapYearTest_CheckLeapYear_ShouldReturnCorrectBoolean(int n, bool b)
        {
            //Arrange
            LeapYear testObject = new LeapYear();
            //Act
            bool actualValue = testObject.checkLeapYear(n);
            //Assert
            Assert.AreEqual(b, actualValue);
        }
    }
}

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
    public class FizzBuzzTest
    {
        [TestCase(-1, "-1")]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(33, "Fizz")]
        [TestCase(55, "Buzz")]
        [TestCase(60, "FizzBuzz")]

        public void FizzBuzzTest_GetOutput_ShouldReturnCorrectValue(int n, string s)
        {
            //Arrange
            FizzBuzz testObject = new FizzBuzz();
            //Act
            string actualValue = testObject.GetOutput(n);
            //Assert
            Assert.AreEqual(actualValue, s);
        }
    }
}

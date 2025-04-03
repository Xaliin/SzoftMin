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
    public class MathemathicsTest
    {
        [TestCase(1, 1, 2)]
        [TestCase(-1, 1, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(100, -1, 99)]

        public void MathemathicsTest_Add_ShouldReturnCorrectValue(int x, int y, int z)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();
            //Act
            int actualValue = testObject.Add(x, y);
            //Assert
            Assert.AreEqual(z, actualValue);
        }

        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, 10, 10)]
        [TestCase(10, 1, 10)]

        public void MathemathicsTest_Max_ShouldReturnCorrectValue(int x, int y, int z)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();
            //Act
            int actualValue = testObject.Max(x, y);
            //Assert
            Assert.AreEqual(z, actualValue);
        }

        [TestCase(8, new int[] { 1, 3, 5, 7 })]
        [TestCase(19, new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 })]
        [TestCase(2, new int[] { 1 })]     
        [TestCase(0, new int[] { })]     

        public void MathemathicsTest_GetOddNumbers_ShouldReturnCorrectValues(int x, int[] z)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();
            //Act
            int[] actualValue = testObject.GetOddNumbers(x).ToArray();
            //Assert
            Assert.AreEqual(z, actualValue);
        }
    }
}

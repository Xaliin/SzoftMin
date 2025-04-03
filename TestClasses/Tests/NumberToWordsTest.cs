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
    public class NumberToWordsTest
    {
        [TestCase(0, "zero")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsZeroOn0Input(int n, string s)
        {
            //Arrange

            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }


        [TestCase(-1, "minus one")]
        [TestCase(-14, "minus fourteen")]
        [TestCase(-10010, "minus ten thousand and ten")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsMinusValueOnNegativeInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(1000000, "one million ")]
        [TestCase(2000000, "two million ")]
        [TestCase(-5000000, "minus five million ")]
        [TestCase(9000009, "nine million and nine")]
        [TestCase(9000099, "nine million and ninety-nine")]
        [TestCase(9000999, "nine million nine hundred and ninety-nine")]
        [TestCase(9009999, "nine million nine thousand nine hundred and ninety-nine")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnMillionInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(1000, "one thousand ")]
        [TestCase(2134, "two thousand one hundred and thirty-four")]
        [TestCase(-5000, "minus five thousand ")]
        [TestCase(90009, "ninety thousand and nine")]
        [TestCase(90088, "ninety thousand and eighty-eight")]
        [TestCase(80888, "eighty thousand eight hundred and eighty-eight")]
        [TestCase(8888, "eight thousand eight hundred and eighty-eight")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnThousandInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(100, "one hundred ")]
        [TestCase(234, "two hundred and thirty-four")]
        [TestCase(-500, "minus five hundred ")]
        [TestCase(909, "nine hundred and nine")]
        [TestCase(777, "seven hundred and seventy-seven")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnHundredInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnLessThanTwentyInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(10, "ten")]
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(40, "fourty")]
        [TestCase(50, "fifty")]
        [TestCase(60, "sixty")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]

        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnMoreThanTwentyAndDividableByTenInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }

        [TestCase(21, "twenty-one")]
        [TestCase(34, "thirty-four")]
        [TestCase(99, "ninety-nine")]
        public void NumberToWordsTest_ConvertNumbers_ReturnsCorrectValueOnMoreThanTwentyAndNotDividableByTenInput(int n, string s)
        {
            //Arrange
            //Act
            string actualValue = NumberToWords.convertNumbers(n);
            //Assert
            Assert.AreEqual(s, actualValue);
        }
    }
}

using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(2, 4, 6, 12)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addition = new UnitTestMethods();

            //Act
            var actual = addition.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(10, 5, 5)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var subtract = new UnitTestMethods();

            //Act
            var actual = subtract.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 2, 6)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiply = new UnitTestMethods();

            //Act
            var actual = multiply.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(36, 6, 6)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new UnitTestMethods();

            //Act
            var actual = divide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void True()
        {
            //Arrange
            var isTrue = new UnitTestMethods();

            //Act
            bool actual = isTrue.True();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void NotNull()
        {
            //Arrange
            var notNull = new UnitTestMethods();

            //Act
            var actual = notNull.NotNull();

            //Assert
            Assert.NotNull(actual);
        }
    }
}

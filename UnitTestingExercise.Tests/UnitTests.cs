using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 2, 3, 6)]            //Add test data <-------
        [InlineData(10, 20, 5, 35)]
        [InlineData(5, -5, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            // create a Calculator object


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);

        }



        [Theory]
        [InlineData(5, 5, 0)]//Add test data <-------
        [InlineData(10, 1, 9)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test2 = new Calculator();
            //Act
            var actual2 = test2.Sub(minuend, subtrhend); Assert.Equal(expected, actual2);
            //Assert

        }

        [Theory]
        [InlineData(1, 1, 1)]//Add test data <-------
        [InlineData(9, 9, 81)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test3 = new Calculator();
            //Act
            var actual3 = test3.Multi(num1, num2);
            //Assert
            Assert.Equal(expected, actual3);
        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(4, 1, 4)]
        [InlineData(8, 2, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new Calculator();
            //Act
            var actual4 = test4.Div(num1, num2);
            //Assert
            Assert.Equal(expected, actual4);
        }

    }
}

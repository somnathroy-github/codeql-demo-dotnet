using System;
using Xunit;
using MyConsoleApp; // Import the namespace of your console application classes

namespace MyConsoleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(3, 4);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Subtract(7, 4);

            // Assert
            Assert.Equal(3, result);
        }
    }
}

using Xunit;
using System;

namespace CopilotTestDrive.Tests;

    public class ProgramTests
    {
        [Fact]
        public void AddWithOverflowCheck_ValidNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = MyMathHelper.AddWithOverflowCheck(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void AddWithOverflowCheck_LargePositiveNumbers_ThrowsOverflowException()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 1;

            // Act & Assert
            var exception = Assert.Throws<OverflowException>(() =>
                MyMathHelper.AddWithOverflowCheck(a, b));
            Assert.Equal("Overflow occurred while adding the two integers.", exception.Message);
        }

        [Fact]
        public void AddWithOverflowCheck_LargeNegativeNumbers_ThrowsOverflowException()
        {
            // Arrange
            int a = int.MinValue;
            int b = -1;

            // Act & Assert
            var exception = Assert.Throws<OverflowException>(() =>
                MyMathHelper.AddWithOverflowCheck(a, b));
            Assert.Equal("Overflow occurred while adding the two integers.", exception.Message);
        }

        [Fact]
        public void AddWithOverflowCheck_EdgeCase_MaxAndMinValue()
        {
            // Arrange
            int a = int.MaxValue;
            int b = int.MinValue;

            // Act
            int result = MyMathHelper.AddWithOverflowCheck(a, b);

            // Assert
            Assert.Equal(-1, result);
        }
    }

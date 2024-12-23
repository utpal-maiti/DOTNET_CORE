using App_ClassLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_XUnitTest
{
    public class Calculator_Tests
    {

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Add(2, 3);
            //Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -1, -2)]
        [InlineData(-1, 1, 0)]
        public void Add_ReturnsCorrectSum_WithVariousInputs(int a, int b, int expected)
        {
            var calculator = new Calculator();
            var result = calculator.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}

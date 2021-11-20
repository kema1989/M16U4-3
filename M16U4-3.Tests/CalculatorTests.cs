using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace M16U4_3.Tests
{
    public class CalculatorTests
    {
        public Calculator calculator = new Calculator();

        [Fact]
        public void AdditionMustReturnCorrectValue()
        {
            Assert.Equal(399, calculator.Addition(7, 49, 343));
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            Assert.Equal(24, calculator.Multiplication(2, 3, 4));
        }
    }
}

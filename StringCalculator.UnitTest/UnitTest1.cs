using System;
using Xunit;
using StringCalculator;

namespace StringCalculator.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Input_One_Should_Display_One()
        {
            Calculator stringCalculator = new Calculator();

            var actual = stringCalculator.add("1");

            Assert.Equal(1, actual);

        }
    }
}

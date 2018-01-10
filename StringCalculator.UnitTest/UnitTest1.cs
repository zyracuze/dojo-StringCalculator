using System;
using Xunit;
using StringCalculator;

namespace StringCalculator.UnitTest
{
    public class UnitTest1
    {
        Calculator calculator = new Calculator();

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void Input_TextNumber_Display_Number(string inputText, int expectedResult)
        {
            int actualResult = calculator.Add(inputText);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,3", 6)]
        public void Input_MultipleTextNumber_Display_SumNumber(string inputMultipleText, int expectedResult)
        {
            int actualResult = calculator.Add(inputMultipleText);

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void Input_Empty_Display_Zero()
        {
            int actualResult = calculator.Add("");

            Assert.Equal(0, actualResult);
        }
    }
}

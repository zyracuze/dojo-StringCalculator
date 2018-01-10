using System;

namespace StringCalculator
{
    public class Calculator
    {

        public int Add(string inputText)
        {
            if (IsMultipleTextNumber(inputText))
            {
                return SumNumber(inputText);
            }

            if (IsTextNumberEmpty(inputText))
                return 0;

            return Number(inputText);
        }

        private int Number(string inputText)
        {
            return int.Parse(inputText);
        }

        private bool IsTextNumberEmpty(string inputText)
        {
            return inputText == "";
        }

        private int SumNumber(string inputText)
        {
            string[] textArray = inputText.Split(",");

            int sumNumber = 0;
            foreach (var textNumber in textArray)
            {
                sumNumber += int.Parse(textNumber);
            }

            return sumNumber;
        }

        private bool IsMultipleTextNumber(string inputText)
        {
            return inputText.Contains(",");
        }
    }
}

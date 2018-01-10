using System;

namespace StringCalculator
{
    public class Calculator
    {

        public int Add(string inputText)
        {
            if(inputText.Contains(",")) {
                string[] textArray = inputText.Split(",");
                
                int sumNumber = 0;
                foreach(var textNumber in textArray) {
                    sumNumber+= int.Parse(textNumber);
                }

                return sumNumber;
            }
            
            if(inputText == "")
                return 0;

            return int.Parse(inputText);
        }
    }
}

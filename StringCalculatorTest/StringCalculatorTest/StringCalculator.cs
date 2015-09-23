using System;
using System.Linq;

namespace StringCalculatorTest
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            char delimiter = ',';
            if (input.StartsWith("//"))
            {
                delimiter = input[2];
                input = input.Substring(3);
            }
            var numbers = input.Split(new []{delimiter,'\n'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            return numbers.Sum();
        }
    }
}
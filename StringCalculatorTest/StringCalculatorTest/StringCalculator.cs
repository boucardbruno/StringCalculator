using System;
using System.Linq;

namespace StringCalculatorTest
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            var numbers = input.Split(new []{','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            return numbers.Sum();
        }
    }
}
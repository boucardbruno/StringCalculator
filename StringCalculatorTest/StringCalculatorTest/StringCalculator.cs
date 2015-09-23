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
            var numbers =
                input.Split(new[] {delimiter, '\n'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var negativesNumbers = numbers.FindAll(n => n < 0);
            if (negativesNumbers.Any())
                throw new Exception(string.Format("Negatives not allowed: {0}",string.Join(",", negativesNumbers)));

            return numbers.Sum();
        }
    }
}
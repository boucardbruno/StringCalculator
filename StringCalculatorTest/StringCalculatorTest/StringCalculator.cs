using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorTest
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            return ExtractNumbers(input).Sum();
        }

        private static IEnumerable<int> ExtractNumbers(string input)
        {
            var delimiter = ',';
            if (input.StartsWith("//"))
            {
                delimiter = input[2];
                input = input.Substring(3);
            }

            var numbers = input.Split(new[] {delimiter, '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var negativesNumbers = numbers.FindAll(n => n < 0);
            if (negativesNumbers.Any())
                throw new Exception($"Negatives not allowed: {string.Join(",", negativesNumbers)}");

            return numbers;
        }
    }
}
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
            var numbers = ExtractInput(input)
                .Split(new[] {ExtractDelimiter(input), '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            HandleNegativesNumbers(numbers);

            return numbers;
        }

        private static void HandleNegativesNumbers(List<int> numbers)
        {
            var negativesNumbers = numbers.FindAll(n => n < 0);
            if (negativesNumbers.Any())
                throw new Exception($"Negatives not allowed: {string.Join(",", negativesNumbers)}");
        }

        private static string ExtractInput(string input)
        {
            if (input.StartsWith("//"))
            {
                input = input.Substring(3);
            }
            return input;
        }

        private static char ExtractDelimiter(string input)
        {
            var delimiter = ',';

            if (input.StartsWith("//"))
            {
                delimiter = input[2];
            }
            return delimiter;
        }
    }
}
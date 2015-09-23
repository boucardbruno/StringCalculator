using NUnit.Framework;

namespace StringCalculatorTest
{
    public class StringCalculatorTests
    {

        [Test]
        public void Should_return_zero_when_input_is_empty()
        {  
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(string.Empty);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }


        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Should_return_number_when_input_contains_a_number(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Should_sum_when_input_contains_two_numbers()
        {
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add("1,2");
            int expected = 3;

            Assert.AreEqual(expected, actual);

        }
    }

    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            var numbers = input.Split(',');
            if (numbers.Length == 1) return int.Parse(input);
            return int.Parse(numbers[0]) + int.Parse(numbers[1]);
        }
    }
}

using NUnit.Framework;

namespace StringCalculatorTest
{
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }
        [Test]
        public void Should_return_zero_when_input_is_empty()
        {
            Assert.AreEqual(0, _stringCalculator.Add(string.Empty));
        }


        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Should_return_number_when_input_contains_a_number(string input, int expected)
        {
            Assert.AreEqual(expected, _stringCalculator.Add(input));
        }


        [Test]
        public void Should_sum_when_input_contains_two_numbers()
        {
            Assert.AreEqual(3, _stringCalculator.Add("1,2"));

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

using System;
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

        [Test]
        public void Should_sum_when_input_contains_unknown_number_of_numbers()
        {
            Assert.AreEqual(6, _stringCalculator.Add("1,2,3"));
        }

        [Test]
        public void Should_sum_when_input_contains_new_lines_between_numbers()
        {
            Assert.AreEqual(6, _stringCalculator.Add("1\n2,3"));
        }

        [Test]
        public void Should_sum_when_input_contains_custom_delimiter()
        {
            Assert.AreEqual(3, _stringCalculator.Add("//;\n1;2"));
        }

        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "Negatives not allowed: -1,-3")]
        public void Should_throw_an_exception_when_input_contains_negatives_numbers()
        {
            _stringCalculator.Add("-1,2,-3");
            Assert.Fail();
        }
    }
}
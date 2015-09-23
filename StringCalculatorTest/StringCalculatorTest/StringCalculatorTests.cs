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
    }

    public class StringCalculator
    {
        public int Add(string input)
        {
            return 0;
        }
    }
}

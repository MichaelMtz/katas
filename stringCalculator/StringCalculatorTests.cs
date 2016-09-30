using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCalculator
{
    [TestFixture]
    public class StringCalculatorTests
    {
        StringCalculator stringCalculator;

        [SetUp]
        public void init()
        {
            stringCalculator = new StringCalculator();
        }

        [Test]
        public void Given_empty_string_should_return_zero()
        {
            int result = stringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Given_one_number_should_return_same_digit()
        {
            int result = stringCalculator.Add("5");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Given_two_numbers_should_return_their_sum()
        {
            int result = stringCalculator.Add("5,5");
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Given_several_numbers_with_coma_delimiters_should_return_their_sum()
        {
            int result = stringCalculator.Add("5,5,50");
            Assert.AreEqual(60, result);
        }

        [Test]
        public void Given_several_numbers_with_several_lines_and_coma_delimiter_should_return_their_sum()
        {
            int result = stringCalculator.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Given_several_numbers_with_several_lines_and_specified_delimiter_should_return_their_sum()
        {
            int result = stringCalculator.Add("//;\n2;3");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Given_there_are_negative_numbers_should_throw_exception_with_all_of_them_in_the_message()
        {
            var ex = Assert.Throws<Exception>(() => stringCalculator.Add("//;\n2;-5;3;-10"));
            Assert.That(ex.Message, Is.EqualTo("Negative numbers are invalid: " + "-5 -10"));
        }

        [Test]
        public void Given_there_is_one_negative_number_should_throw_exception_with_all_of_them_in_the_message()
        {
            var ex = Assert.Throws<Exception>(() => stringCalculator.Add("-4"));
            Assert.That(ex.Message, Is.EqualTo("Negative numbers are invalid: " + "-4"));
        }

    }
}
 
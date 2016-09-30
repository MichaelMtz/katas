using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ShouldReturnOneGivenOne()
        {
            string result = FizzBuzz.Parse(1);
            Assert.IsTrue(result == "1");
        }

        [Test]
        public void ShouldReturnTwoGivenTwo()
        {
            string result = FizzBuzz.Parse(2);
            Assert.IsTrue(result == "2");
        }

        [Test]
        public void ShouldReturnFizzGivenThree()
        {
            string result = FizzBuzz.Parse(3);
            Assert.IsTrue(result == "Fizz");
        }

        [Test]
        public void ShouldReturnFizzGivenSix()
        {
            string result = FizzBuzz.Parse(6);
            Assert.IsTrue(result == "Fizz");
        }

        [Test]
        public void ShouldReturnFuzzGivenFive()
        {
            string result = FizzBuzz.Parse(5);
            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void ShouldReturnFuzzGivenTen()
        {
            string result = FizzBuzz.Parse(10);
            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void ShouldReturnFizzBuzzGivenFifteen()
        {
            string result = FizzBuzz.Parse(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void ShouldReturnFizzBuzzGivenThirty()
        {
            string result = FizzBuzz.Parse(30);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}

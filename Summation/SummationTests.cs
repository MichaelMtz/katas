using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Summation
{
    [TestFixture]
    public class SummationTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(5, 15)]
        [TestCase(8, 36)]
        public void Should_return_the_sum_from_one_till_the_number_passed(int num, int expected)
        {
            int result = new Summation().Sum(num);
            Assert.AreEqual(expected, result);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    [TestFixture] 
    public class potterTest
    {
        [Test]
        public void should_return_8_for_one_book()
        {
            int[] books = new int[] { 1, 0, 0, 0, 0 };
            var price = Potter.Calculate(books);
            Assert.AreEqual(price, 8);
        }

        [Test]
        public void should_discount_5_percent_for_two_different_books()
        {
            int[] books = new int[] { 1, 1, 0, 0, 0 };
            double discountedPrice = 8 * 2 * (0.95);
            var price = Potter.Calculate(books);
            Assert.AreEqual(price, discountedPrice);
        }
    }
}

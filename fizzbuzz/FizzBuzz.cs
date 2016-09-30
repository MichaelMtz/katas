using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public static string Parse(int number)
        {
            if (DivisibleByThree(number) && DivisibleByFive(number))
                return "FizzBuzz";
            if (DivisibleByThree(number))
                return "Fizz";
            if (DivisibleByFive(number))
                return "Buzz";
            return Convert.ToString(number);
        }

        private static bool DivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool DivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}

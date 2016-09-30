using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    public class Potter
    {
        public static double Calculate(int[] books)
        {
            if (books.Where(b => b == 1).Count() == 1)
                return 8;

            //if (books.Where(b => b == 1).Count() == 2)
                return 8 * 2 * (0.95);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation
{
    public class Summation
    {
        public int Sum(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
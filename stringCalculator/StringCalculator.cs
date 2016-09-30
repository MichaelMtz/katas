using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCalculator
{
    public class StringCalculator
    {
        private char delimiter;

        public StringCalculator()
        {
            this.delimiter = ',';
        }

        public int Add(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            else
            {
                return AddWithDelimiter(ReadDelimiter(s));
            }
        }

        private int AddWithDelimiter(string s)
        {
            IEnumerable<int> numbers = s.Split(delimiter).
                                        SelectMany(str => str.Split(LineBreak())).Select(str => int.Parse(str));
            numbers = checkForNegativeNumbers(numbers);
            return numbers.Sum(number => number);
        }

        private IEnumerable<int> checkForNegativeNumbers(IEnumerable<int> numbers)
        {
            IEnumerable<int> negativeNumbers = numbers.Where(n => n < 0);
            if (negativeNumbers.Count() > 0)
            {
                throw new Exception("Negative numbers are invalid:" + ConcatenateNumbers(negativeNumbers));
            }

            return numbers;
        }

        private string ConcatenateNumbers(IEnumerable<int> negativeNumbers)
        {
            StringBuilder builder = new StringBuilder();
            negativeNumbers.ToList().ForEach(n => builder.Append(" " + n));

            return builder.ToString();
        }

        private string ReadDelimiter(string s)
        {
            if (s.StartsWith(DelimiterPrefix()))
            {
                this.delimiter = s[2];
                return s.Substring(4);
            }

            return s;
        }

        private string DelimiterPrefix()
        {
            return "//";
        }

        private char LineBreak()
        {
            return '\n';
        }
    }
}

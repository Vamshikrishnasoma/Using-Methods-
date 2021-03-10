using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaxDigit
    {
        static void Main(string[] args)
        {
            MaxDigit m = new MaxDigit();
            Console.WriteLine(m.MaxDigitNumber(292617));
        }
        public int MaxDigitNumber(int num)
        {
            int max = num % 10;
            while(num!=0)
            {
                int digit = num % 10;
                if(digit>max)
                {
                    max = digit;
                }
                num /= 10;
            }
            return max;
        }
    }
}

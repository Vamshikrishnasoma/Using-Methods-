using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine(p.IsPalindrome(121));
        }
        public bool IsPalindrome(int num)
        {
            int copy = num;
            int rev = 0;
            while(num!=0)
            {
                int digit = num % 10;
                rev = rev * 10+digit;
                num /= 10;
            }
            return copy == rev;
        }
    }
}

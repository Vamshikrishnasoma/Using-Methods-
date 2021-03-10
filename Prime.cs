using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Prime
    {
        static void Main(string[] args)
        {
            Prime p = new Prime();
            Console.WriteLine(p.IsPrimeNumber(17));
        }   
        public bool IsPrimeNumber(int num)
        {
            int count = 0;
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            return count == 2;
        }
    }
}

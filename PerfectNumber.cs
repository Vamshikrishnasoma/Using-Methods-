using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            PerfectNumber p = new PerfectNumber();
            Console.WriteLine(p.ISPerfectNumber(6));
        }
        public bool ISPerfectNumber(int num)
        {
            int sum = 0;
            for(int i=1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            return sum == num;
        }
    }
}

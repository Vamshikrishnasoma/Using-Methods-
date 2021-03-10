using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AmstrongNumber
    {
        static void Main(string[] args)
        {
            AmstrongNumber a = new AmstrongNumber();
            Console.WriteLine(a.IsAmstrongNumber(153));
        }
        public bool IsAmstrongNumber(int num)
        {
            int copy = num;
            int sum = 0;
            int count = 0;
            
            while(num!=0)
            {
                int digit = num % 10;
                count++;
                num /= 10;   
            }
            num = copy;
            while(copy!=0)
            {
                int digit = copy % 10;
                int total = powval(digit,count);
                
                sum = sum + total;

                copy /= 10;
            }
           
            return num == sum;
        }
        public static int powval(int digit,int count)
        {
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power* digit;
            }
            return power;
        }
        
    }
}

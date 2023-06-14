using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = calc(n);
            if (m == 1)
                Console.WriteLine("nothing");
            else
                Console.WriteLine("your tax is:" + m);
        }
        
        static int calc(int n)
        {
            if (0 <= n && n <= 483000)
                return -1;
            if (483001 <= n && n <= 600000)
                return (10 * n) / 100;
            if (600001 <= n && n <= 1000000)
                return (15 * n) / 100;
            if (1000001 <= n && n <= 2000000)
                return (20 * n) / 100;

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("addtext");
            int a = int.Parse(Console.ReadLine());

            Console.Write("addtext");
            int n = int.Parse(Console.ReadLine());

            int result = power(a, n);
            Console.WriteLine("{0} {1} {2}", a, n, result);
        }
        static int power(int a, int n)
        {
            int result;

            if (n == 0)
                result = -1;
            else
                result = a * power(a, n-1);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("addtext");
            int n = int.Parse(Console.ReadLine());

            MoveDisk(n, 'A', 'B', 'C');
        }
        static void MoveDisk(int n, char a, char b, char c)
        {
            if (n == 0)
                Console.WriteLine("There is no Tower of Hanoi");
            else if (n == 1)
                Console.WriteLine("Move disk {0} from Tower {1} to Tower {2}", n, a, c);
            else
            {
                MoveDisk(n - 1, a, b, c);
                Console.WriteLine("Move disk {0} from Tower {1} to Tower {2}", n, a, c);

                MoveDisk(n-1, b, c, a);
            }
            
        }
    }
}

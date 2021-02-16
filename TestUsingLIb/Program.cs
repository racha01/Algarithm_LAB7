using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureLib;

namespace TestUsingLIb
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList P = new ArrayList(4);
            ArrayList L = new ArrayList(5);

            P.insert((int)0);
            P.insert((int)2);
            P.insert((int)3);
            P.insert((int)5);

            L.insert((int)20);
            L.insert((int)-6);
            L.insert((int)-5);
            L.insert((int)10);
            L.insert((int)70);

            printElement(L, P);
        }

        static void prinElement(ArrayList L, ArrayList P)
        {
            int Itemp = 0;
            int Ptemp = 0;
            int pos = 0;

            while (Ptemp < P.size())
            {
                while (Itemp < L.size())
                {
                    if ((int)P.peek(Ptemp) > (L.size() - 1))
                    {
                        Console.WriteLine("L[{0}] : Out of order", P.peek(Ptemp));

                        break;
                    }
                    else if ((int)P.peek(Ptemp) == pos)
                    {
                        Console.WriteLine("L[{0}] : {1}", pos, L.peek(Itemp));

                        break;
                    }
                    Itemp++;
                    pos++;
                }
                Ptemp++;
            }
        }
    
    }
}

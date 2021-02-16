using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();

            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-5555", "Jisun");

            Console.Write("Enter :");
            string emp = Console.ReadLine();
            if (employees.ContainsKey(emp))
            {
                
                string empName = (string)employees[emp];
                Console.WriteLine("{0}", empName);
            }
            else
                Console.WriteLine("addtext");
        }
    }
}

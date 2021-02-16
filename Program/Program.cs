using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DataStructureLib;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hashtable data = new Hashtable();
            int value, sum, sum1;
            

            data.Add("10-2", "2");
            data.Add("10-8", "8");
            data.Add("10-16", "16");

            Console.Write("Enter the number you want to convert. :");
            string kay_C = Console.ReadLine();

            Console.Write("Enter a decimal number :");
            value = int.Parse(Console.ReadLine());

            
            ArrayStack S = new ArrayStack(value);
            if (data.ContainsKey(kay_C))
            {
                string kay_V = (string)data[kay_C];

                if (kay_V == "2")
                {
                    int Ans = value * 2;
                    int i = 0;
                    while (true)
                    {
                        i++;
                        if (Ans > 1)
                        {
                            sum = Ans / 2;
                            sum1 = sum % 2;
                            Ans = sum;
                            string objToPush = "" + sum1;
                            S.push(objToPush);
                        }
                        else if (Ans == 1)
                            break;
                    }
                    Console.Write("The resulting binary number is ");
                    while (!S.isEmpty())
                    {
                        string objpoped = (string)S.pop();
                        Console.Write(objpoped);
                    }
                    Console.WriteLine();
                }
                else if (kay_V == "8")
                {
                    int Ans = value * 8;
                    int i = 0;
                    while (true)
                    {
                        i++;
                        if (Ans >= 8)
                        {
                            sum = Ans / 8;
                            sum1 = sum % 8;
                            Ans = sum;
                            //Console.WriteLine(Ans);
                            string objToPush = "" + sum1;
                            S.push(objToPush);

                        }
                        else if (Ans == 1 || Ans == 2 || Ans == 3 || Ans == 4 || Ans == 5 || Ans == 6 || Ans == 7)
                            break;
                    }
                    Console.Write("The resulting binary number is ");
                    while (!S.isEmpty())
                    {
                        string objpoped = (string)S.pop();
                        Console.Write(objpoped);
                    }
                    Console.WriteLine();

                }
                else if (kay_V == "16")
                {
                    int Ans = value * 16;
                    int i = 0;
                    while (true)
                    {
                        
                        i++;
                        if (Ans >= 16)
                        {
                            sum = Ans / 16;
                            sum1 = sum % 16;
                            Ans = sum;
                            //Console.WriteLine(Ans);
                            int objToPush = sum1;
                            string push = "" + sum1;
                            if (objToPush < 10)
                            {
                                objToPush = sum1;
                                S.push(push);
                            }
                            if (objToPush >= 10)
                            {
                                if (objToPush == 10)
                                    push = "A";
                                else if (objToPush == 11)
                                    push = "B";
                                else if (objToPush == 12)
                                    push = "C";
                                else if (objToPush == 13)
                                    push = "D";
                                else if (objToPush == 14)
                                    push = "E";
                                else if (objToPush == 15)
                                    push = "F";
                                S.push(push);
                            }

                        }
                        else if (Ans == 1 || Ans == 2 || Ans == 3 || Ans == 4 || Ans == 5 || Ans == 6 || Ans == 7 || Ans == 8 || Ans == 9 || Ans == 10 || Ans == 11 || Ans == 12 || Ans == 13 || Ans == 14 || Ans == 15)
                            break;
                    }
                    Console.Write("The resulting binary number is ");
                    while (!S.isEmpty())
                    {
                        string objpoped = (string)S.pop();
                        Console.Write(objpoped);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("addtext");
        }   
    }
}

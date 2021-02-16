using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InfixToPostix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            string data = Console.ReadLine();

            string result = infixToPostix(data);
            Console.WriteLine("{0}", result);
        }
         static string  infixToPostix(string data)
        {
            Stack S = new Stack();
            string result = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    S.Push((char)data[i]);
                }
                else if (data[i] == ')')
                {
                    char temp = (char)S.Pop();

                    while (temp != '(')
                    {
                        if (temp != '(')
                            result += temp;
                        else if (S.Count != 0)
                            temp = (char)S.Pop();
                        else
                            break;
                    }
                }
                else if ((data[i] == '+') || (data[i] == '-') || (data[i] == '*') || (data[i] == '/')  || (data[i] == '^'))
                {
                    int priorityNew = getPriority(data[i]);
                    int priorityStack = -1;
                    if (S.Count != 0)
                    {
                        priorityStack = getPriority(data[i]);
                        while (priorityNew <= priorityStack)
                        {
                            char temp = (char)S.Pop();
                            result += temp;
                            if (S.Count != 0)
                                priorityStack = getPriority((char)S.Peek());
                            else
                                break;
                        }
                    }
                    S.Push(data[i]);
                }
                else
                {
                    result += data[i];
                }
            }
            while (S.Count != 0)
            {
                char temp = (char)S.Pop();
                result += temp;
            }
            return result;
        }
        static int getPriority(char sign)
        {
            switch (sign)
            {
                case '(' : return 0;
                case ')' : return 0;
                case '+' : return 0;
                case '-' : return 0;
                case '*' : return 0;
                case '/' : return 0;
                case '^' : return 0;
              
            }
            return -1;
        }
    }
}

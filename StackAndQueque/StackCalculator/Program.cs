using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Channels;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> operacion = new Stack<string>(input.Split().Reverse());
            int result = 0;
            while (operacion.Count >1)
            {
                int firstdig = int.Parse(operacion.Pop());
                string oper = operacion.Pop();
                int seconddig = int.Parse(operacion.Pop());

                if (oper=="+")
                {
                    operacion.Push((firstdig + seconddig).ToString());
                }
                else if (oper=="-")
                {
                    operacion.Push((firstdig - seconddig).ToString());
                }
            }

            Console.WriteLine(operacion.Pop());
        }
    }
}
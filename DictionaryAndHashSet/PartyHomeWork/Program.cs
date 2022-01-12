using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input.Length == 8)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        char ch = input[i];
                        if (i==0 && char.IsDigit(ch)==true)
                        {
                            VIP.Add(input);
                            break;
                        }
                        else
                        {
                            regular.Add(input);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input !="END")
            {
                if (VIP.Contains(input))
                {
                    VIP.Remove(input);
                }
                else if (regular.Contains(input))
                {
                    regular.Remove(input);
                }
                input = Console.ReadLine();
            }

            int count = VIP.Count + regular.Count;
            Console.WriteLine(count);
            foreach (var item in VIP)
            {
                Console.WriteLine(item);
            }

          
            foreach (var itm in regular)
            {
                Console.WriteLine(itm);
            }
        }
    }
}

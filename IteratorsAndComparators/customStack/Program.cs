using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CustomSatck<string> staks = new CustomSatck<string>();

            while (input != "END")
            {
                string[] splited = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (splited[0]=="Push")
                {
                   
                    staks.Push(splited.Skip(1).Select(x=>x.Split(",").First()).ToArray());
                }
                else if (splited[0]=="Pop")
                {
                    try
                    {
                        staks.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                      
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in staks)
            {
                Console.WriteLine(item);
            }

            foreach (var sql in staks)
            {
                Console.WriteLine(sql);
            }
        }
    }
}

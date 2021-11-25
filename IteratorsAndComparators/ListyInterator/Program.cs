using System;
using System.Linq;

namespace Listy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListyIterator<string> comand = null;
            while (input != "END")
            {
                var splited = input.Split();
                if (splited[0] == "Print")
                {
                    comand.Print();
                }

                else if (splited[0] == "Move")
                {
                    Console.WriteLine(comand.Move());
                }
                else if (splited[0] == "HasNext")
                {
                    Console.WriteLine(comand.HasNext());
                }
                else if (splited[0] == "Create")
                {
                    comand = new ListyIterator<string>(splited.Skip(1).ToArray());
                }
                input = Console.ReadLine();
            }
        }
    }
}

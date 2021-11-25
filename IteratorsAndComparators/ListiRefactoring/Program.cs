using System;
using System.Linq;

namespace ListyIterator1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ListyIterator<string> comands = null;

            while (input !="END")
            {
                var splited = input.Split();

                if (splited[0]=="Create")
                {
                    comands = new ListyIterator<string>(splited.Skip(1).ToArray());
                }
                else if (splited[0]=="Move")
                {
                    Console.WriteLine(comands.Move());
                }
                else if (splited[0]=="HasNext")
                {
                    Console.WriteLine(comands.HasNext());
                }
                else if (splited[0]=="Print")
                {
                    comands.Print();
                }
                else if (splited[0]=="PrintAll")
                {
                    comands.PrintAll();
                }

                input = Console.ReadLine();
            }
        }
    }
}

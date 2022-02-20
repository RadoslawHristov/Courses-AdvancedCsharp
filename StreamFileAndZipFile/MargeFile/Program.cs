using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readar = new StreamReader("../../../../FileOne.txt"))
            using (StreamReader readar2 = new StreamReader("../../../../FileTwo.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../../Output.txt"))
                {
                    string line = readar.ReadLine();
                    string twoLine = readar2.ReadLine();
                    while (line != null && twoLine !=null)
                    {
                        writer.WriteLine(line);
                            line = readar.ReadLine();
                            writer.WriteLine(twoLine);
                            twoLine = readar2.ReadLine();
                    }
                }
            }
        }
    }
}

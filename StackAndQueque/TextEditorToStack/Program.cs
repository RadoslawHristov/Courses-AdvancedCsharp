using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int countOfComand = int.Parse(Console.ReadLine());
            //
            //Stack<string> rezult = new Stack<string>();
            //StringBuilder sb = new StringBuilder();
            //
            //for (int i = 0; i < countOfComand; i++)
            //{
            //    string[] comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //
            //    if (comand[0] == "1")
            //    {
            //        string com = comand[1];
            //        for (int j = 0; j < com.Length; j++)
            //        {
            //            rezult.Push(com[j].ToString());
            //            sb.Append(com[j]);
            //        }
            //    }
            //    else if (comand[0] == "2")
            //    {
            //        int count = int.Parse(comand[1]);
            //        while (count > 0)
            //        {
            //            rezult.Pop();
            //            count--;
            //        }
            //
            //        sb.Append(rezult.Count());
            //    }
            //    else if (comand[0] == "3")
            //    {
            //        int index = int.Parse(comand[1]);
            //        int count = 0;
            //        foreach (var item in rezult.Reverse())
            //        {
            //            string ch = item;
            //            count++;
            //            if (count==index)
            //            {
            //                Console.WriteLine(ch);
            //            }
            //
            //        }
            //    }
            //    else if (comand[0] == "4")
            //    {
            //        for (int k = sb.Length - 1; k >= 0; k--)
            //        {
            //            rezult.Push(sb[k].ToString());
            //        }
            //    }
            //
            //
            //
            //
            //}

            int n = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push(builder.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        builder.Append(input[1]);
                        stack.Push(builder.ToString());
                        break;
                    case 2:
                        int number = int.Parse(input[1]);
                        builder.Remove(builder.Length - number, number);
                        stack.Push(builder.ToString());
                        break;
                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        builder = new StringBuilder();
                        builder.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}

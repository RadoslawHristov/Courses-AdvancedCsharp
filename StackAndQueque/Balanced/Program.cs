using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> bracket = new Stack<char>();
            bool isBalanced = true;
            foreach (var ch in input)
            {
                if (ch == '[' || ch == '{' || ch == '(')
                {
                    bracket.Push(ch);
                }

                else if (bracket.Count ==0)
                {
                    isBalanced = false;
                    break;
                }
                else if (ch == ']' && bracket.Peek()=='[')
                {
                    bracket.Pop();
                }
                else if (ch == '}' && bracket.Peek() == '{')
                {
                    bracket.Pop();
                }
                else if (ch == ')' && bracket.Peek() == '(')
                {
                    bracket.Pop();
                }
                else
                {
                    isBalanced = false;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

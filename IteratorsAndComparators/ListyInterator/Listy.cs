using System;
using System.Collections.Generic;

namespace Listy
{
    public class ListyIterator<T>
    {

        private List<T> listy;

        private int curentindex;

        public ListyIterator(params T[] data)
        {
            listy = new List<T>(data);
            curentindex = 0;
        }

        public bool HasNext() => curentindex < listy.Count - 1;

        public void Print()
        {
            if (listy.Count==0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine($"{listy[curentindex]}");
            }
        }

        public bool Move()
        {
            bool moves = HasNext();
            if (moves)
            {
                curentindex++;
            }
            return moves;
        }

    }
}
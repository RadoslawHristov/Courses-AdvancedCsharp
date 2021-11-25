using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator1
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> listy;

        private int curentIndex;

        public ListyIterator(params T[] data )
        {
            listy = new List<T>(data);
            curentIndex = 0;
        }

        public bool HasNext() => curentIndex < listy.Count - 1;

        public bool Move()
        {
            bool istrue = HasNext();

            if (istrue)
            {
                curentIndex++;
            }

            return istrue;
        }

        public void Print()
        {
            if (listy.Count==0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            Console.WriteLine($"{listy[curentIndex]}");
        }

        public void PrintAll()
        {
            foreach (var item in listy)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < listy.Count; index++)
            {
                yield return listy[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
    }
}

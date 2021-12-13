using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
        where T: IComparable<T>
    {
        private List<T> Boxes = new List<T>();

        public void AddElement(T element)
        {
            Boxes.Add(element);
        }
        public void SwapElement(int first, int second)
        {
            T item = this.Boxes[first];//0
            this.Boxes[first] = this.Boxes[second];//index 0= second
            this.Boxes[second] = item;// second=item(first)

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Boxes)
            {
                sb.AppendLine($"{item.GetType()}: {item.ToString()}");
            }

            return sb.ToString();
        }

        public int GetCount(T element)
        {
            int count = 0;

            foreach (var item in Boxes)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }



    }
}

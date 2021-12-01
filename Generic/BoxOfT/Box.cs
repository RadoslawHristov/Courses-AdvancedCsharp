using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;

        private List<T> box = new List<T>();

        public int Count
            => box.Count;

        public void Add(T element)
        {
            box.Add(element);
        }

        public T Remove()
        {
            T removeElement = this.box.Last();
            this.box.RemoveAt(this.box.Count - 1);
            return removeElement;
        }
    }
}

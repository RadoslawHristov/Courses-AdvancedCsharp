using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> element;

        public Box()
        {
            Element = new List<T>();
        }

        public List<T> Element
        {
            get { return element; }
            set { element = value; }
        }

        public int Count => Element.Count;

        public void Add(T elementT)
        {
            this.Element.Add(elementT);
        }

        public T Remove()
        {
            var result = this.Element.Last();
            this.Element.RemoveAt(Element.Count-1);
            return result;
        }
    }
}

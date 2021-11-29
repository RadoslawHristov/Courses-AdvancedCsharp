using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class CustomSatck<T> : IEnumerable<T>
    {
        private List<T> stack;

        public CustomSatck(params T[] data)
        {
            stack = new List<T>();
        }

        public void Push(params T[] element)
        {
            foreach (var item in element)
            {
                stack.Insert(stack.Count, item);
            }
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T elements = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return elements;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

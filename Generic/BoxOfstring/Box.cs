using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public T Boxes  { get; set; }

        public Box(T box)
        {
            Boxes = box;
        }

        public override  string ToString()
        {
            return $"{Boxes.GetType()}: {Boxes}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    where T: struct
    {
        private T left;
        private T right;

        public EqualityScale(T lEft,T rIght)
        {
            this.left = lEft;
            this.right = rIght;
        }

        public static bool AreEqual(T t1,T t2)
        {
            bool result = t1.Equals(t2);
            return result;
        }
    }
}

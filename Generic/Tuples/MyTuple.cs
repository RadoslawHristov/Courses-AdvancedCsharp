using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    class MyTuple<item1, item2>
    {
        public MyTuple(item1 firstitem, item2 seconditem2)
        {
            FirstItem = firstitem;
            SecondItem2 = seconditem2;
        }

        public item1 FirstItem { get; set; }

        public item2 SecondItem2 { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class MyThreeuple<Item1, Item2,Item3>
    {
        public MyThreeuple(Item1 first,Item2 second,Item3 three)
        {
            FirstItem = first;
            SecondItem = second;
            ThreeItem = three;
        }

        public Item1 FirstItem { get; set; }

        public Item2 SecondItem { get; set; }

        public Item3 ThreeItem { get; set; }


        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThreeItem}";
        }
    }
}

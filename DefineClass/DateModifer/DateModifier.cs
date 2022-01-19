using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int DaysCalculateTwoDate(string firstdate, string secontdate)
        {
            DateTime dateOne=DateTime.Parse(firstdate);
            DateTime twoDate=DateTime.Parse(secontdate);

            int day =(dateOne - twoDate).Days;
            return day;
        }


    }
}

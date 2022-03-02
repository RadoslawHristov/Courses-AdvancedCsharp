using System;

namespace TwoDateMod
{
    public class Date_Modifier
    {
        public DateTime DateTimeOne { get; set; }
        public DateTime DateTimeTwo { get; set; }


        public Date_Modifier(DateTime date1,DateTime date2)
        {
            this.DateTimeOne = date1;
            this.DateTimeTwo = date2;
        }

        public int GetDayForTwoDate()
        {
            var result = Math.Abs((DateTimeOne - DateTimeTwo).Days);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = "No Name";
            this.Age = 1;
        }
      



        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}

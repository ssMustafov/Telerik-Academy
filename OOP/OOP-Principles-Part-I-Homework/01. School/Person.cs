using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Person
    {
        private string name;

        protected Person(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("The name must contain atleast 3 letters.");
            }

            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
    }
}

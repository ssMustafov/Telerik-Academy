using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public class Student: Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The grade must be greater or equal than 1.");
                }
                
                this.grade = value;
            }
        }

        public string FirstName
        {
            get { return base.FirstName; }
        }

        public string LastName
        {
            get { return base.LastName; }
        }

        public override string ToString()
        {
            return string.Format("Im {0} {1}, and Im in {2} grade.", base.FirstName, base.LastName, this.grade);
        }
    }
}

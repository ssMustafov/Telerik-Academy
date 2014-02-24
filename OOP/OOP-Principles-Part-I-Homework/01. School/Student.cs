using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Student: Person
    {
        private int classNumber;
        private string comment;

        public Student(int classNumber, string name, string comment)
            : base(name)
        {
            this.classNumber = classNumber;
            this.comment = comment;
        }

        public Student(int classNumber, string name)
            : this(classNumber, name, null)
        {
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Teacher: Person
    {
        private List<Discipline> disciplines;
        private string comment;
        
        public Teacher(string name, List<Discipline> disciplines, string comment) : base(name)
        {
            this.disciplines = disciplines;
            this.comment = comment;
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this(name, disciplines, null)
        {
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (value.Count < 0)
                {
                    throw new ArgumentException("The list of disciplines cannot be empty.");
                }

                this.disciplines = value;
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}

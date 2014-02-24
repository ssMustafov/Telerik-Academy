using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class SchoolClass
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string nameOfClass;
        private string comment;

        public SchoolClass(List<Student> students, List<Teacher> teachers, string nameOfClass, string comment)
        {
            this.students = students;
            this.teachers = teachers;
            this.nameOfClass = nameOfClass;
            this.comment = comment;
        }

        public SchoolClass(List<Student> students, List<Teacher> teachers, string nameOfClass)
            : this(students, teachers, nameOfClass, null)
        {
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("The class must have atleast 1 student.");
                }

                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("The class must have atleast 1 teacher.");
                }

                this.teachers = value;
            }
        }

        public string NameOfClass
        {
            get { return this.nameOfClass; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}

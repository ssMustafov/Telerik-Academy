using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Students
{
    class Student
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student {FirstName = "Ivan", LastName = "Ivanov", Age = 9},
                new Student {FirstName = "Alisiq", LastName = "Todorova", Age = 15},
                new Student {FirstName = "Zoro", LastName = "Manafov", Age = 21},
                new Student {FirstName = "Gaco", LastName = "Bacov", Age = 23}
            };

            // Ex. 3
            var names =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var item in names)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            // Ex. 4
            var firstAndLastName =
                from student in students
                where student.Age > 18 && student.Age < 24
                select student.FirstName + " " + student.LastName;
            Console.WriteLine();
            foreach (var item in firstAndLastName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            // Ex 5
            var orderNames = students.OrderByDescending(s => s.FirstName).ThenByDescending(st => st.LastName).ToList();
            foreach (var item in orderNames)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}

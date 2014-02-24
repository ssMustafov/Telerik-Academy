using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class SchoolTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(20, "Pesho"));
            students.Add(new Student(16, "Maria"));

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0} - Class number: {1}", student.Name, student.ClassNumber);
            }

            List<Discipline> disciplines = new List<Discipline>();
            disciplines.Add(new Discipline("C# Programming", 15, 30));
            disciplines.Add(new Discipline("Java Programming", 12, 20));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Nakov", disciplines));
            teachers.Add(new Teacher("Georgi", disciplines));

            Console.WriteLine("Teachers:");
            foreach (var teach in teachers)
            {
                foreach (var disp in teach.Disciplines)
                {
                    Console.WriteLine("Name: {0} - Discipline: {1}", teach.Name, disp.Name);
                }
            }

            SchoolClass schoolClass = new SchoolClass(students, teachers, "12A");

            Console.WriteLine(schoolClass.NameOfClass);
        }
    }
}
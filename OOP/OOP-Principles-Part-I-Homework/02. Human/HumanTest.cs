using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    class HumanTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Draganov", 10),
                new Student("Ivan", "Mitkov", 11),
                new Student("Dimitar", "Peshev", 5),
                new Student("Gosho", "Ivanov", 7),
                new Student("Petio", "Peshev", 12),
                new Student("Dragan", "Petkanov", 11),
                new Student("Kiro", "Peshev", 8),
                new Student("Asen", "Apeshev", 8),
                new Student("Petkan", "Beshev", 10),
                new Student("Gaco", "Bacov", 10)
            };

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0,-8} - Grade: {1}", student.FirstName, student.Grade);
            }

            students = students.OrderBy(student => student.Grade).ToList();

            Console.WriteLine();
            Console.WriteLine("Students sorted by grade in asc order:");
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0,-8} - Grade: {1}", student.FirstName, student.Grade);
            }

            List<Worker> workers = new List<Worker>()
              { 
                  new Worker( "Worker1","W1Lastname", 250, 7 ),
                  new Worker( "Worker2","W2Lastname", 350, 11 ),
                  new Worker( "Worker3","W3Lastname", 50, 2 ),
                  new Worker( "Worker4","W4Lastname", 1500, 1 ),
                  new Worker( "Worker5","W5Lastname", 800, 11 ),
                  new Worker( "Worker6","W6Lastname", 210, 14 ),
                  new Worker( "Worker7","W7Lastname", 30, 8 ),
                  new Worker( "Worker8","W8Lastname", 145, 5 ),
                  new Worker( "Worker9","W9Lastname", 731, 9 ),
                  new Worker( "Worker10","W10Lastname", 235, 13 )
              };

            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine();
            Console.WriteLine("Workers sorted by money per hour:");
            foreach (var worker in workers)
            {
                Console.WriteLine("Name: {0,-8} - Money per hour: {1:F2}", worker.FirstName, worker.MoneyPerHour());
            }

            var merged = workers.Concat<Human>(students).ToList();
            merged = merged.OrderBy(item => item.FirstName).ThenBy(item => item.LastName).ToList();

            Console.WriteLine();
            Console.WriteLine("Merged and sorted:");
            foreach (var list in merged)
            {
                Console.WriteLine("{0} {1}", list.FirstName, list.LastName);
            }
        }
    }
}

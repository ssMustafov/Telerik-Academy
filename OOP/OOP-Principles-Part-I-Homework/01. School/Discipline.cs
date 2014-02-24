using System;

namespace _01.School
{
    public class Discipline
    {
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, string comment, int numberOfLectures, int numberOfExrecises)
        {
            this.Name = name;
            this.comment = comment;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExrecises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExrecises)
            : this(name, null, numberOfLectures, numberOfExrecises)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The discipline must be atleast 3 letters.");
                }

                this.name = value;
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }        

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
        }
    }
}

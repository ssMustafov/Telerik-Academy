using System;

namespace Animals
{
    public enum EnumAnimalSex
    {
        Male, Female
    }
    
    public class Animal
    {
        private string name;
        private EnumAnimalSex sex;
        private int age;

        public Animal(string name, EnumAnimalSex sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.Age = age;
        }

        public EnumAnimalSex Sex
        {
            get { return this.sex; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The animal cannot be under zero years old.");
                }

                this.age = value;
            }
        }

        public static int AverageAge(Animal[] animals)
        {
            int sum = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                sum += animals[i].Age;
            }
            return sum / animals.Length;
        }
    }
}

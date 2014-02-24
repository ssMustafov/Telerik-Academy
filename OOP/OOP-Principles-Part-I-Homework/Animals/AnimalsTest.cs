using System;

namespace Animals
{
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Kootka", EnumAnimalSex.Female, 9);
            Kitten kit = new Kitten("Kotence", 1);
            Console.WriteLine(cat.Sex);
            Console.WriteLine(cat.ProduceSound());
            Console.WriteLine(kit.Age);

            Dog[] dogs =
            {
                new Dog("Dog1", EnumAnimalSex.Male, 8),                
                new Dog("Balkan", EnumAnimalSex.Male, 3),
                new Dog("asd", EnumAnimalSex.Female, 2), 
                new Dog("asd", EnumAnimalSex.Female, 11),
                new Dog("asd", EnumAnimalSex.Female, 0), 
                new Dog("asd", EnumAnimalSex.Female, 18), 
                new Dog("asd", EnumAnimalSex.Female, 7), 
                new Dog("asd", EnumAnimalSex.Female, 5)
            };

            Kitten[] kits =
            {
                new Kitten("Kitty", 3),
                new Kitten("Kit", 7),
                new Kitten("Kitten1", 2)
            };

            Frog[] frogs =
            {
                new Frog("Frog1", EnumAnimalSex.Male, 11),
                new Frog("Ram", EnumAnimalSex.Male, 3)
            };

            Console.WriteLine("Average age of array Dogs: {0}", Animal.AverageAge(dogs));
            Console.WriteLine("Average age of array Kitten: {0}", Animal.AverageAge(kits));
            Console.WriteLine("Average age of array Frogs: {0}", Animal.AverageAge(frogs));
        }
    }
}

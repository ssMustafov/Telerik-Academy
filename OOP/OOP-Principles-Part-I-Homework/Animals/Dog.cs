using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, EnumAnimalSex sex, int age) : base(name, sex, age)
        {
        }
        
        public string ProduceSound()
        {
            return "Bau, bau...";
        }
    }
}

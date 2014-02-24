using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, EnumAnimalSex sex, int age) : base(name, sex, age)
        {
        }
        
        public string ProduceSound()
        {
            return "Myau, myau...";
        }
    }
}

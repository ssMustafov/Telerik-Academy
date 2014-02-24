using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, EnumAnimalSex sex, int age) : base(name, sex, age)
        {
        }
        
        public string ProduceSound()
        {
            return "Plok, plok...";
        }
    }
}

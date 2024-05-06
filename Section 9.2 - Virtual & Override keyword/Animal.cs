using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._2___Virtual___Override_keyword
{
    internal class Animal
    {
        // Name har encapsulated setter(private) man kan ikke sætte variabel udefra class 
        public string Name { get; private set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age, bool isHungry)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        // virtual gør at classes der nedarver, fra Animal kan override metode
        public virtual void MakeSound()
        {

        }

        // virtusl class med logik, som classses der nedarver fra blot kan override
        public virtual void Eat()
        {

            if (IsHungry) 
            {
                Console.WriteLine($"{Name} is eating");
            } else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

        public override string ToString() 
        {
            return $"{Name}, {Age}, {IsHungry}";
        }
    }
}

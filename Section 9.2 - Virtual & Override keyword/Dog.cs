using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._2___Virtual___Override_keyword
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        // constructor fra base class bruges til at initalizere variabler(Polymorfi)
        public Dog(string name, int age, bool isHungry) : base(name, age, isHungry)
        {
            IsHappy = true;
        }

        // her overrides Eat metoden fra Animal class der nedarves fra
        public override void Eat()
        {
            // hvis man vil bruge funktionaliteten der er i Animal class bruges:
            base.Eat();  // Polymorfi
        }

        public override void MakeSound()
        {
            // Da hvert animal laver forsk. lyde, laves metode til specifikt en hund 
            Console.WriteLine($"Woof woof");
        }

        public override void Play()
        {
            // Hvis hunden er glad vil den lege
            if (IsHappy)
            {
                base.Play(); // Polymorfi
            }
        }

        public override string ToString()
        {
            return base.ToString(); // Polymorfi (vi genbruger kode fra Animal class og køre kode der )
        }
    }
}

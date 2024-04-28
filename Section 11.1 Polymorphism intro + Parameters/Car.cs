using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11._1_Polymorphism_intro___Parameters
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Horsepower: {HP}, Color: {Color}");
        }

        // for at kunne kalde RepairCar i både BMW og Audi class, skal:
        // class Car metodedn RepairCar være virtual
        // RepairCar metoderne i BMW & Audi skal være override
        public virtual void RepairCar()
        {
            Console.WriteLine(@"Car was repaired");
        }
    }
}

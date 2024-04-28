using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11._1_Polymorphism_intro___Parameters
{
    internal class Audi : Car
    {
        private string brand = "Audi";

        public string Model { get; set; }

        // base (hp, color) betyder man kalder constructor i class man nedarver fra (Car),
        // og bruger dents constructor til at istanciers hp og color (da den gør det i forvejen) 
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;            
        }

        // ved at bruge keyword 'new' bruges ShowDetails fra DENNE class, og IKKE fra Car class
        public new void ShowDetails()
        {
            Console.WriteLine($"Brand : {brand}, Model: {Model}, Hp: {HP}, Color: {Color}");
        }

        public override void RepairCar()
        {
            Console.WriteLine($"The {brand} {Model} was repaired!");
        }
    }
}

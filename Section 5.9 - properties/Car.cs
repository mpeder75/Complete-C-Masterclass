//! Properties

// Properties har indbyggede getters og setters
// og derfor er der ingen getters/setter, og fields er alle properties isstedet for

// Hvorfor bruges properties?
// så man kan gøre fields private og igennem properties tilgå fields (encapsulation) 

namespace Section_5._9___properties
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;

        // property der håndtere get og set for variablen _name 
        public string Name
        {
            get { return _name; }   // get returnere _name
            set { _name = value; }  // set når man udefra skal sette -name gøres det igennem Name prop's set method
        }
        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // constructors
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "red";
            Drive();
        }
        public Car(String name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";
            Drive();
        }
        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
            Drive();
        }

        // methods
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }
        public void Stop()
        {
            Console.WriteLine($"{_name} stopped!");
        }
        public void Details()
        {
            Console.WriteLine($"Name of car: {this._name} \nHp of {this._name}: {this._hp}\nColor is {_color}\n ");
        }

    }
}




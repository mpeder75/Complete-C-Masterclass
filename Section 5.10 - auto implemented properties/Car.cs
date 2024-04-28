namespace Section_5._10___auto_implemented_properties
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;
        //! (ABSTRACTION) NÅR en property deklareres SKABER compiler en SKJULT private variabel ex. _maxSpeed; 
        //! og det er DENNE private variabel, property bruger sin get og set 

        // auto implemented property - der benytter implicit backin field
        public int MaxSpeed { get; set; }

        public string Name
        {
            get { return _name; }   // get accessor
            set { _name = value; }  // set accesssor
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




namespace Section_5._8___getters
{
    internal class Car
    {
        // fields/instansvariable
        private string _name;
        private int _hp;
        private string _color;

        // setters
        public void setName(string name)
        {
            if (name == "")
            {
                _name = "Default";
            }
            else
            {
                _name = name;
            }
        }
        public void setHp(int hp)
        {
            _hp = hp;
        }
        public void setColor(string color)
        {
            _color = color;
        }

        // getters
        public string GetName()
        {
            return _name+ " suffix";
        }
        public int GetHp()
        {
            return _hp * _hp;
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

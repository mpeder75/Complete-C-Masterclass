
namespace Section_5._7___setters
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;

        // setters
        public void setName(string name)
        {
            if (name == "")
            {
                _name = "Default";
            } else
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

        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";           
        }

        public Car(String name, string color = "Dark blue")
        {
            _name = name;
            _hp = 0;
            _color = "red";          
        }

        public Car(string name, int hp, string color)
        {
            this._name = name;
            this._hp = hp;
            this._color = color;            
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

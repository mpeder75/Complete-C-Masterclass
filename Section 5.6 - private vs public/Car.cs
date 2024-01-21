namespace Section_5._6___private_vs_public
{
    internal class Car
    {
        public string _name;
        private int _hp;
        private string _color;

        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
            Drive();
        }

        public Car(String name, string color = "Dark blue")
        {
            _name = name;
            _hp = 0;
            _color = "red";
            Drive();
        }

        public Car(string name, int hp, string color)
        {
            this._name = name;
            this._hp = hp;
            this._color = color;
            Drive();
        }

        // prvivate method - hvis objekter skal bruge denne metode, skal den køres fra constructor
        private void Drive()
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

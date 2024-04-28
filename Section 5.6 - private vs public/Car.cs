namespace Section_5._6___private_vs_public
{
    internal class Car
    {
        public string _name;  // public, man kan sætte _name i program.cs
        private int _hp;      // private, man kan IKKE sætte -hp i program.cs - kræver en set method
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
            Drive(); // private method køres fra constructor, Drive() kaldes hver gang et Car objekt istancieres
        }

        // private method - hvis objekter skal bruge denne metode, skal den køres fra constructor
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

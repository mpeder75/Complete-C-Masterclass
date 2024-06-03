namespace Section_5._2___constructor
{
    internal class Car
    {
        // variabler der beskriver karakteristika af den type class vil modellere 
        private string _name;
        private string _model;
        private int _hp;
        private string _color;

        // constructor til at initialize variabel
        public Car(string name, string model, string color, int hp)
        {
            this._name = name;
            this._model = model;
            this._color = color;
            this._hp = hp;
            Drive();
        }        
        
        // metoder der beskriver dents generelle opførsel 
        public void Drive()
        {
            Console.WriteLine($"{_name} {_model} is driving");
        }

        public void Stop () 
        {
            Console.WriteLine($"{_name} {_model} stopped!");
        }

        public void Details ()
        {
            Console.WriteLine($"Manufacturer & model: {_name} {_model} \nHas Hp: {_hp} \nColor: {_color}\n");
        }        
    }
}


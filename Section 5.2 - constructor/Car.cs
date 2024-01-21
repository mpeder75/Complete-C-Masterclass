namespace Section_5._2___constructor
{
    internal class Car
    {
        // Fields/instanc variabler
        private string _name;  // private field der opbevare navn (ex. audi) på objekt Car audi = ...
        private int _hp;
        private string _color;

        // Constructor, hp & color sættes til faste værdier, NÅR objekt skal istancieres kan dette ændres ved istancieringen 
        public Car(String name, int hp = 0, string color = "Dark blue") 
        {
           _name = name;     // Når der istancieres objekt i program cs. med navn, sættes værdi for field her
           _hp = hp;         
           _color = color;                               
        }
        
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        public void Stop () 
        {
            Console.WriteLine($"{_name} stopped!");
        }

        public void Details ()
        {
            Console.WriteLine($"Name of car: {this._name} \nHp of {this._name}: {this._hp}\nColor is {_color}\n ");
        }
        
    }
}

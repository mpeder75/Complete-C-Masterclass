namespace Section_5._3___overload_constructor;

// Når constructor overloades, kan man oprette objektet med forsk. variabler initailiseret
// default consftgructor har ingen (ønsker at overloade den skal der være andre parametre)
internal class Car
{
    private string _name;
    private string _model; 
    private int _hp;
    private string _color;

    // default constuctor
    public Car()
    {
      
    }
    // overloaded constructor 1 - color hardcodes
    public Car(string name, string color = "Dark blue")
    {
        _name = name;
        _hp = 0;
        _color = "red";
    }
    // overloaded constructor 2 - initialisere alle variabler
    public Car(string name, string model, int hp, string color)
    {
        this._name = name;
        this._model = model;
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


namespace Section_5._3___overload_constructor;

//! Overloaded constructor
// Nåpr man overlaoder en constructor, er forskellen i metode signaturen i parameterne
// default consftgructor har ingen, og hvis man øsnker at overlaode den skal der være andre parametre
internal class Car
{
    private string _name;
    private int _hp;
    private string _color;

    // default constuctor
    public Car()
    {
        _name = "Car";
        _hp = 0;
        _color = "red";
    }
    // overloaded constructor 1
    public Car(String name, string color = "Dark blue")
    {
        _name = name;
        _hp = 0;
        _color = "red";
    }
    // overloaded constructor 2
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


public abstract class Animal
{
    public abstract void MakeSound();
}

public class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }
}

public class Goat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Baa!");
    }
}

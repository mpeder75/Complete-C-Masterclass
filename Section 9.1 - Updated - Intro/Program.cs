

Dog myDog = new Dog();
myDog.Eat("Treat");
myDog.MakeSound();



// Interface: HUSK interface laves uden implementerings detaljer
public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
}


// class der implementer interface
public class Dog : IAnimal
{
    public void Eat(string food)
    {
        Console.WriteLine($"Dog ate {food}");
    }

    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}



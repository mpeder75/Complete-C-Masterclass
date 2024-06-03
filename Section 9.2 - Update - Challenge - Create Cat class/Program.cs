/*
CHALLENGE TIME!
Create another implementation of the IAnimal Interface, a "Cat" class.
It needs to be able to eat and make sounds. Similar to what we have already done before!
This challenge is just for you to practice Implementing your own Classes that implement IAnimal. In the next lecture, we will show you what we came up with.
*/




public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
}

public class Dog : IAnimal
{
    public void Eat(string food)
    {
        Console.WriteLine($"Dog ate {food}");
    }

    public void MakeSound()
    {
        Console.WriteLine("Bark bark");
    }
}

public class Cat : IAnimal
{
    public void Eat(string food)
    {
        Console.WriteLine($"Cat ate {food}");
    }

    public void MakeSound()
    {
        Console.WriteLine("Miaw mniaw");
    }
}
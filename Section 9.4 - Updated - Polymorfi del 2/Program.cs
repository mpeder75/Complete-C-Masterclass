
//! Polymorfi: Der oprettes Animal datatype, men opbevare et Dog objekt
// Dog nedarver fra Animal, og derfor kan en child class Dog blive set som en Animal
// # Dette betyder at man kan KUN kalde metoder og fields der eksistere i Animal class
//? MEN hvis man laver metoder i Dog der Overrider, bruges de istedet for

Animal myDog = new Dog();
myDog.MakeSound();



public class Animal
{
    public virtual void MakeSound() 
    {
        Console.WriteLine("Some generic sound");
    } 
}

public class Dog: Animal
{
    public override void MakeSound()   
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
    }
}



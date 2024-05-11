// Der finde 2 forskellige typer IEnumerable 
// 1. IEnumerable<T> for generic collections - BRUG denne
// 2. IEnumerable for ikke-generiske collections - Denne kræver unboxing

// IEnumerable gør et muligt at iterere igennem en collection
// med ex. et foreach loop
using System.Collections;

DogShelter myDogShelter = new DogShelter();

foreach (Dog dog in myDogShelter)
{
    if (!dog.IsNaughtyDog)
    {
        dog.GiveTreat(2);
    } else
    {
        dog.GiveTreat(1);
    }
}







class Dog
{
    public string Name { get; set; }
    public bool IsNaughtyDog { get; set; }

    public Dog(string name, bool isNaughtyDog)
    {
        Name = name;
        IsNaughtyDog = isNaughtyDog;
    }

    public void GiveTreat(int numberOfTreats)
    {
        Console.WriteLine($"{Name} get {numberOfTreats} treats");
    }
}


class DogShelter : IEnumerable<Dog>
{
    public List<Dog> dogs;

    public DogShelter()
    {
        dogs = new List<Dog>()
        {
            new Dog("Casper",false),
            new Dog("Sif", true),
            new Dog("Oreo", false),
            new Dog("Pixel", false)
        };
    }

    public IEnumerator<Dog> GetEnumerator()
    {
        // denne returnere hver individuelle dog element
        return dogs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    { 
        throw new NotImplementedException();
    }
}
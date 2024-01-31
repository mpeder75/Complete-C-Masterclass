

// Person objekter istancieres
Person p1 = new Person() { Name = "Aiden", Age = 41 };
Person p2 = new Person() { Name = "Sif", Age = 69 };
Person p3 = new Person() { Name = "Walter", Age = 12 };
Person p4 = new Person() { Name = "Anatoli", Age = 35 };


// Person objekter gemnmes i en List
List<Person> listPerson = new List<Person> { p1, p2, p3, p4 };


//? Metode kaldes med titel, lstet persone, og reference til method 
DisplayPeople("Kids:", listPerson, IsMinor);
DisplayPeople("Adults:", listPerson, IsAdult);
DisplayPeople("Seniors:", listPerson, IsSenior);


//? Metode der looper igennem liste, og bruger metoder til at filtrere
void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
{
    Console.WriteLine(title);

    foreach(Person p in listPerson)
    {
        if(filter(p))
        {
            Console.WriteLine($"{p.Name} is years old {p.Age}");
        }
    }

}


// ========== Filters ==========
bool IsMinor(Person p)
{
    return p.Age < 18;
}

bool IsAdult(Person p)
{
    return p.Age > 21 && p.Age < 65;
}

bool IsSenior(Person p)
{
    return p.Age > 65;
}

// ========== ref til delegate ==========
public delegate bool FilterDelegate(Person p);



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }    
}





//todo Lambda

List<Person> people = new List<Person>
{
    new Person {Name = "John", Age = 33},
    new Person {Name = "Mary", Age = 31},
    new Person {Name = "Bob", Age = 38},
}; 

// liste sorteret med lambda på age
var sortedByAge = people.OrderBy(person => person.Age);

foreach(var person in sortedByAge)
{
    Console.WriteLine($"Sorted by age: {person.Name} is {person.Age}");
}

// liste sorteret på name i asc
var sortedByName = people.OrderBy(person => person.Name);

foreach (var person in sortedByName)
{
    Console.WriteLine($"Sorten by name: {person.Name} is {person.Age}");
}



/*
 
 person repræsentere en Person, og person er hver Person i listen en ad gang
 
 altså, i første iteration er person "John", i anden iteration er person = "Mary"...
  
 
 Lambda skal læses: (person => people.Age);

 Tag alle person i people list og sorter dem på deres Age

 Eller

 people.OrderBy(person => person.Age);

 people orderby each person by person.Age
 
*/

class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
}


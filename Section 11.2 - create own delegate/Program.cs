//todo Lave egne delegate

//? Vi vil filtrere persons på age


// delegate oprettes, som tager et Person objekt som parameter
public delegate bool FilterDelegate(Person p);

// List a Persons
Person p1 = new Person() {
    Name = "Bob",
    Age = 55;
};






public class Person
{

    public Person()
    {
        
    }

    // propertys
    public string Name { get; set; }
    public int Age { get; set; }

}
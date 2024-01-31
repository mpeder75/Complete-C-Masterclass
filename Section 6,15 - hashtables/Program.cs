using System.Collections;

//! Hashtables - en samling af dictonary entries

// Eksempel: Man har et system med students, og alle students skal kunne identificeres unikt
// Dette kan gøres med hashtables

// StudentId bliver "primary key"



// declare hashtable
Hashtable studentsTabel = new Hashtable();      


// tilføje student objekter på forsk måder
Student stud1 = new Student (1, "John", 98);
Student stud2 = new Student { Id = 2, Name = "Alice", GPA = 76 };  // kræver der er en default constructor
Student stud3 = new Student(id: 3, name: "Bob", gpa: 43);
Student stud4 = new Student { Id = 4, Name = "Steve", GPA = 55};


// assign data til hashtable - (Key, objectToAdd) - skal addes med en key (Id)
studentsTabel.Add(stud1.Id, stud1);
studentsTabel.Add(stud2.Id, stud2);
studentsTabel.Add(stud3.Id, stud3);
studentsTabel.Add(stud4.Id, stud4);


// hente værdi fra hashtable - henter ligesom array, man SKAL castes til samme objekttype (Student)
Student storedStudent = (Student)studentsTabel[1];

Student storedStudent1 = (Student)studentsTabel[stud2.Id];  // alternativ


// printe fra hashtable
Console.WriteLine($"Student Id: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");


// loope igennem hashtable - Kræver man laver en temp variabel i loop
foreach (DictionaryEntry entry in studentsTabel)
{
    Student temp = (Student)entry.Value;            // temp variabel 
    Console.WriteLine($"Student Id: { temp.Id}");
    Console.WriteLine($"Student Name: { temp.Name}");
    Console.WriteLine($"Student GPA: { temp.GPA}");
}

              // Bedre metode til loop
foreach (Student value in studentsTabel.Values)
{
    Console.WriteLine($"Student Id: {value.Id}");
    Console.WriteLine($"Student Name: {value.Name}");
    Console.WriteLine($"Student GPA: {value.GPA}");
}



class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    public Student() { }

    public Student(int id, string name, float gpa) 
    {    
        this.Id = id;
        this.Name = name;
        this.GPA = gpa;
    }
}
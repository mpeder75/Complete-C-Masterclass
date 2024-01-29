//todo Forskellige måder at istanciere et objekt på


// 1. BEDST - kræver IKKE tom constructor
Student stud1 = new Student() { Id = 1, Name = "poul", GPA = 1000 };


// 2 - denne måde kræver en tom constructor
Student stud2 = new Student { Id = 2, Name = "Alice", GPA = 95 };

//
Student stud3 = new Student(1, "John", 98);


// 3
Student stud4 = new Student(id: 3, name: "Bob", gpa: 88);


// 4
Student stud5 = new Student(4, "Eva", 92) { GPA = 94 }; 




class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    public Student()
    {
        
    }

    public Student(int id, string name, float gpa)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = gpa;
    }
}


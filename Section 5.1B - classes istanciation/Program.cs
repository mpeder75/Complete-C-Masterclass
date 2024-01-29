//todo Forskellige måder at istanciere et objekt på


// 1.
Student stud1 = new Student(1, "John", 98);


// 2 - denne måde kræver en tom constructor
Student stud2 = new Student { Id = 2, Name = "Alice", GPA = 95 };


// 3
Student stud3 = new Student(id: 3, name: "Bob", gpa: 88);









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
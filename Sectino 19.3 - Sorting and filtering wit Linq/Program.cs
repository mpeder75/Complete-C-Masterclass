
using System.Threading.Channels;

Universitymanager manager = new Universitymanager();

Console.WriteLine("Male Strudents");
manager.MaleStudents();

Console.WriteLine("\nFemale students");
manager.FemaleStudents();

Console.WriteLine("\nTrans-gender students");
manager.TransGenderStudents();

Console.WriteLine("\nSorted students by age");
manager.SortStudentsByAge();

Console.WriteLine("\nAll Osxofr students");
manager.AllStudentsFromOxford();




class Universitymanager
{
    List<University> universities;
    List<Student> students;

    public Universitymanager()
    {
        universities = new List<University>();
        students = new List<Student>();

        universities.Add(new University { Id = 1, Name = "Yale" });
        universities.Add(new University { Id = 2, Name = "Oxford" });

        students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
        students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
        students.Add(new Student { Id = 2, Name = "Frank", Gender = "male", Age = 19, UniversityId = 1 });
        students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 17, UniversityId = 2 });
        students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
        students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
    }

    // LINQ - returnere male students
    public void MaleStudents()
    {
       //IEnumerable<Student> maleStudents = students.Where(student => student.Gender == "male");
       var sorted = students.Where(student => student.Gender == "male");

       foreach (Student student in sorted) student.Print();
    }

    // LING - returner female students
    public void FemaleStudents()
    {
        IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;

        foreach (Student student in femaleStudents)
        {
            student.Print();
        }
    }

    // LINQ - returner trans-gender students
    public void TransGenderStudents()
    {
        IEnumerable<Student> transGenderStudents = from student in students where student.Gender == "trans-gender" select student;

        foreach (Student student in transGenderStudents)
        {
            student.Print();
        }
    }

    // LINQ - sort students by age
    public void SortStudentsByAge()
    {
        var sortedStudents = students.OrderByDescending(student => student.Age);

        foreach (Student student in sortedStudents) student.Print();        
    }

    // LINQ - fin alle students fra Oxford - JOIN 2 tabeller
    public void AllStudentsFromOxford()
    {
        // Her bruges foreign key in Student, så der kan søges efter UniversityId = 2 (Oxford) 

        IEnumerable<Student> oxfStudent =
            from student in students join university in universities on student.UniversityId equals university.Id where university.Name == "Oxford" select student;

        foreach (Student student in oxfStudent) student.Print();       
    }
}

class University
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Print()
    {
        Console.WriteLine("University {0} with id {1}", Name, Id);
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    
    public int UniversityId { get; set; }

    public void Print()
    {
        Console.WriteLine($"{Name} with id: {Id}, {Gender} and age: {Age} from University :{UniversityId}");
    }
}




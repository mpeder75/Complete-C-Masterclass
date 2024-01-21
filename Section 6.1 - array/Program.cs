//! index er en refernce til en plads i et array

//! element er en værdi der opbevares i et specifikt array


// declare & initialize int array med længde 5 (alle indexes har værdien 0)
int[] grades = new int[5];

// assign values til indexes
grades[0] = 12;
grades[1] = 7;
grades[2] = 10;
grades[3] = 4;
grades[4] = 2;

// declare & initialize array i et hug
int[] myGrades = { 12, 12, 7, 10, 7 };

// eller
int[] myOtherGrades = new int[] { 10, 7, 4, 7, 7 };


// tilgå værdi i index
Console.WriteLine($"grades index 0 is: {grades[0]}");

// ændre værdier efter værdier er assignesd
string input = Console.ReadLine();
grades[0] = int.Parse(input);
Console.WriteLine("Grades at index 0 is now " + grades[0]);

// længden på array
Console.WriteLine(myGrades.Length); 



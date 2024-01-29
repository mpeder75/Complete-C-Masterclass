
//! Printe index og element ud vha foreach samt beregne average

int[] grades = { 15, 13, 8, 12, 6, 16 };

int i = 1;
foreach (int grade in grades)
{
    Console.WriteLine($"Grades  of student {i}= {grades[i]}");
    i++;
}

// Getaverage kaldes med array som argument
double result = GetAverage(grades);
Console.WriteLine($"Average is: {result}");


// metode tager array som parameter
static double GetAverage(int[] grades)
{
    double average;
    int sum = 0;

    for (int i = 0; i < grades.Length; i++)
    {
        sum += grades[i];
    }
    average = (double) sum / grades.Length;
    return average;
}





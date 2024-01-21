/*
This time, you have to fill out two methods:

GetOdd will get an array as input and will print every odd number from it to the console;

GetEven will do the same for evens;
*/

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Exercise myExercise = new Exercise();

myExercise.GetOdd(array);

myExercise.GetEven(array);



class Exercise
{
    public void GetOdd(int[] Array)
    {
        foreach (int i in Array)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(Array[i-1]);
            }
        }
    }

    public void GetEven(int[] Array)
    {
        foreach(int i in Array)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even " + Array[i+1]);
            }
        }
    }
}

  
 
/* Exercise
Create a array of happiness in mainmethod and assign it 5 values.
Create a method 'SunIsShining' which has an array of type int as paramater.
This method should increase the argument given by 2, for each entry
Call this method in the main mewthod and use "happiness" as the argument.
Creat a foreach loop in the main method to write alæl values onto the colsoole
 */

int[] happiness = { 1, 2, 3, 4 };

SunIsShining(happiness);

int counter = 1;
foreach (int i in happiness)
{
    Console.WriteLine($"Happiness at index {counter} is: {i}");
    counter++;
}


void SunIsShining(int[] array)
{ 
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] += 2;
    }
}




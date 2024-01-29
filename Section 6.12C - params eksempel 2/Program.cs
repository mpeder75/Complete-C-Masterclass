
//! Eksempel: Find lavest værdi

int min = MinV2(6,5,4,2,8,9,12);

Console.WriteLine($"min value is: {min}");



int MinV2(params int[] numbers)
{

    int min = int.MaxValue;

    foreach (int number in numbers)
    {
        if(number < min)
        {
            min = number;
        }
    }
    return min;
}
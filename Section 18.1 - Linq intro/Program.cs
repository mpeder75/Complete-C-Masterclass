//IDEA: Linq kan bruges på collections, og databaser til at lave søgninger


// Eksempel: print tal fra int array der kan deles med 2

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

OddNumbers(numbers);


static void OddNumbers(int[] numbers)
{
    // LINQ - IEnumerable er som en List, men med flere funktioner
    // Her láves query of filtrere for division med 2
    IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

    foreach (int i in oddNumbers)
    {
        Console.WriteLine($"Odd numbers are: {i}");
    }
}


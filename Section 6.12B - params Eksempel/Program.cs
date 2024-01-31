// method der lægger tal sammen som passes til method og returnere resultast

int sum1 = Sum(1, 2, 4, 5, 7, 9);
int sum2 = Sum(10, 20, 40, 50, 70, 90);
int sum3 = Sum(100, 200, 400, 500, 700, 900);

Console.Write($"Sum1={sum1}, Sum2={sum2}, Sum3={sum3}");



static int Sum(params int[] numbers) 
{
    int total = 0;
    foreach (int i in numbers)
    {
        total += i;
    }
    return total;
}


// method der beregner gennensnittet af tal passet til method og returnere resultast

double avg1 = Average(13, 7, 8, 17);
Console.WriteLine("\n" + avg1);

static double Average(params double[] numbers)
{
    double total = 0;
    int count = 0;

    foreach (double number in numbers )
    {
        total += number;
        count++;
    }
    return total / count; 
}
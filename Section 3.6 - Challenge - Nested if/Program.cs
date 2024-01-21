/*
This time you have to complete the NestedCheck method.
It is supposed to print the right message in the terminal depending on the given value:

    - when the value is divisible by 3. You have to print "Divisible by 3.";

    - when it is not divisible by 3, but divisible by 7 print "Divisible by 7."

    - Otherwise:

            - when it is an odd number, print "Odd number."

             - if not, print "Even number."

Example:

the number is equal to 3, "Divisible by 3." is printed;
the number is equal to 28, "Divisible by 7." is printed;
the number is equal to 1, "Odd number." is printed; 
 */

int number = int.Parse(Console.ReadLine());

NestedCheck(number);


static void NestedCheck(int number)
{
    if (number % 3 == 0)
    {
        Console.WriteLine("Divisible by 3.");

        IsEvenOrOdd(number);        

    } else if (number % 7 == 0)
    {
        Console.WriteLine("Divisible by 7");

        IsEvenOrOdd(number);
    }
}

static void IsEvenOrOdd (int number)
{
    if (number / 2 != 0)
    {
        Console.WriteLine("Odd number");
    }
    else if (number / 2 == 0)
    {
        Console.WriteLine("Even number");
    }

}
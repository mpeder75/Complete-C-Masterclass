/*
//! while loop - Syntax

int counter = 0;

while (counter < 20)
{
    Console.WriteLine(counter);
    counter++;
}


*/

// program, så når der trykkes "enter" vil counter variabel tælles op og vises på skærm

int count = 0;
int totalPassengers = 0;

Console.WriteLine("Press enter to increment passenger counter\n");

while (true)
{
    if (Console.ReadLine().Equals(""))
    {
        count++;
        totalPassengers++;

        if (totalPassengers >= 36)
        {
            Console.WriteLine($"Max capacity of {totalPassengers} is reached");
            Console.WriteLine("Bus is shutting doors, and drives");
            break;
        }
    }
    Console.WriteLine($"{count} passenger has entered the bus");
    Console.WriteLine($"Total passenger ammount is: {totalPassengers}");
}
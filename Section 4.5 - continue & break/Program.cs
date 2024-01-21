
// Break: break ud af loop når counter = 3

for (int counter = 0;  counter < 10 ; counter++)
{
    Console.WriteLine(counter);

    if (counter == 3)
    {
        Console.WriteLine("At 3 we stop");
        break;
    }
}




// Continue: continue gør at iteration "skippes"

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} is an even number");
        continue;  // continue vil hoppe over iteration når i er et lige tal
    }
    Console.WriteLine(i);
}


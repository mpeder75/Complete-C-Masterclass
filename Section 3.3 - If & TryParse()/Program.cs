

Console.WriteLine("Enter a temperature");
string temperature = Console.ReadLine();

int numTemp;
int number;

if (int.TryParse(temperature, out number))
{
    numTemp = number;
}
else
{
    numTemp = 0;
    Console.WriteLine("Value entered, was no number, 0 set to temperature");
}


if (numTemp < 20)
{
    Console.WriteLine("Take the coat");
}
else if (numTemp == 20)
{
    Console.WriteLine("Pants and pullover should be fine");
}
else if (numTemp > 20)
{
    Console.WriteLine("Weather supeer warm");
}
else
{
    Console.WriteLine("Shorts should be fine");
}


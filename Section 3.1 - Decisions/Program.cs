
Console.WriteLine("Enter a degree");
int temperature = int.Parse(Console.ReadLine());


if (temperature < 10)
{
    Console.WriteLine("Take your coat on");
}
else if (temperature == 10)
{
    Console.WriteLine("It's 10 degree's");
}
else if (temperature > 10)
{
    Console.WriteLine("No coat needed");
}
else if (temperature >= 20)
{
    Console.WriteLine("Shorts weather approved");
}
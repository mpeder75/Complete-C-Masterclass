Console.WriteLine("Enter a number to be TryParsed");
string numberAsString = Console.ReadLine();

int parsedValue;

bool success = int.TryParse(numberAsString, out parsedValue);
Console.WriteLine(success);

if (success)
{
    Console.WriteLine($"numberAsString has succesful been parsed to {parsedValue}");
}
else
{
    Console.WriteLine($"TryParse failed");
}


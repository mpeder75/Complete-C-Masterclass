
//! Eksempel 1: Hvis bruger indtaster alt andet end en int, vil der komme en exception
//! Eksempel 2: Hvis bruger indtaster en int der er alt for stor

Console.WriteLine("Please enter a number");
string userInput = Console.ReadLine();


try                         // try bruges til at prøve at køre koden først
{
    int userInputAsInt = int.Parse(userInput);
} 
catch (FormatException e)   // HVIS den IKKE kan køre, vil Catch block blive kørt istedet
{
    Console.WriteLine(e.Message + " Please enter integer, and only a integers");
} 
catch (OverflowException e) // HVIS bruger indtaster værdi der er for stor for en int
{
    Console.WriteLine(e.Message);
}



//! Eksempel 3: Finally block

Console.WriteLine("Please enter a number");
string userInput2 = Console.ReadLine();

try 
{                        
    int userInputAsInt = int.Parse(userInput);
}
catch (FormatException e)   
{
    Console.WriteLine(e.Message + " Please enter integer, and only a integers");
}
catch (OverflowException e) 
{
    Console.WriteLine(e.Message);
}
finally  // Denne kodeblock KØRES ALTID uanset hvad de forgåendne catch block gør
{
    Console.WriteLine("Finally block køres altid, uanset hvad");
}


//! Eksempel: Divider med 0

Console.WriteLine("Enter num1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num2");
int num2 = int.Parse(Console.ReadLine());

try
{
    int result = num1 / num2;
    Console.WriteLine(result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message + "Need to input hoolw numbers not 0");
}
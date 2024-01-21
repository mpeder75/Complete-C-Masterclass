//! Class

// HUSK - En class er et blueprint der bruges når man istanciere et objekt af samme type

// Ex. Man har lavet en Car class og kan ny istanciere objekter af typen Car

// For at tilføje en Class, højreclick på Solution -> Add -> Class  (ctrl+shift+A)
using Section_5._1___Class_intro;


Car audi = new Car();

audi.Drive();
Console.WriteLine("Prewss 1 to stop car");

string userInput = Console.ReadLine();

if (userInput == "1")
{
    audi.Stop(); 
} else
{
    Console.WriteLine("Cars drives indefinetly");
}




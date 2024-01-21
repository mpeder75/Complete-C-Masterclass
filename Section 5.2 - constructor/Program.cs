using Section_5._2___constructor;

Car audi = new Car("Audi A4", 450, "White");
Car bmw = new Car("BMW A5", 355, "Black");

audi.Details();
bmw.Details();

audi.Drive();
bmw.Drive();

Console.WriteLine("Press 1 to stop car");

string userInput = Console.ReadLine();

if (userInput == "1")
{
    audi.Stop();
    bmw.Stop();
}
else
{
    Console.WriteLine("Cars drives indefinetly");
}
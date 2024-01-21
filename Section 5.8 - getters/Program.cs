using Section_5._8___getters;

Car myCar = new Car();
myCar.setName("my best car");
Console.WriteLine("myCar name is: " +myCar.GetName());

Console.WriteLine($"Hp is: {myCar.GetHp()}");

myCar.Details();
Car audi = new Car("Audi A4", 250, "blue");
audi.Details();
Car bmw = new Car("BMW M5", 350);
bmw.Details();


Console.WriteLine("press 1 to stop the car!");
string userInput = Console.ReadLine();
if (userInput == "1")
{
    audi.Stop();
}
else
{
    Console.WriteLine("Car drives indefinetely");
}


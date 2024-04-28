using Section_5._9___properties;

Car myCar = new Car();

// Her kaldes Name property, som går ind og setter _name til at være "MyAudiA3"
myCar.Name = "MyAudiA3";
myCar.Hp = 350;
myCar.Color = "Racing red";

// Her bruges blot getteren på Name property og man får returneret navnet
Console.WriteLine($"{myCar.Name}");



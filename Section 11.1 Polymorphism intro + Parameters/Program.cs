using Section_11._1_Polymorphism_intro___Parameters;


var cars = new List<Car>
{
    new Audi(200, "Blue", "A4" ),
    new BMW(220, "Red", "520i")
};

// for at kunne kalde RepairCar i både BMW og Audi class, skal:
// class Car metodedn RepairCar være virtual
// RepairCar metoderne i BMW & Audi skal være override
// Dvs. man looper gennem alle objekter der er af typen 
foreach (var car in cars)
{
    car.RepairCar();
}



// for at bruge ShowDetails metoderne i class BMW & Audi:
// Objekterne SKAL oprettes af typen BMW & Audi, dernæst
// i BMW og Audi class skal ShowDetails habe new keyword i sen metode signatur
BMW bmwM3 = new BMW(215, "Blackblue", "m3");
Audi audiA6 = new Audi(230, "Silver", "A6");
bmwM3.ShowDetails();
audiA6.ShowDetails();



// hvis man vil kalde ShowDetails fra 

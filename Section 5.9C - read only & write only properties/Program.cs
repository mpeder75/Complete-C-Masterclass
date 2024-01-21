using Section_5._9C___read_only___write_only_properties;

Car myCar = new Car();

myCar.Name = "MyAudiA3";
myCar.Hp = 350;
myCar.Color = "Racing red";

// man kan ikke længere sette maxspeed, da den er Read only
// myCar.MaxSpeed = 210;
Console.WriteLine("Max speed is: " + myCar.MaxSpeed);

// Weight kan sette men ikke gettes - hentes istedet gennem Details()
myCar.Weight = 2100;
myCar.Details();

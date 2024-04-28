using Section_5._6___private_vs_public;

//! Encapsulation: Når man gør instansvaroiabler og/eller methods PRIVATE
// encapusulation gør at man ikke kan tilgå visse dele af et system,
// men man skal gøre det igennem methods som getters og setters udefra

// Man kan også gøre methods private, hvilket betyder de ikke kan tilgåes udefra
// HVIS man gerne vil have sine methods private i en class, kan man blot køre methods i constructor
// Så køres private methods hver gang objektet istancieres

Car myCar = new Car();

myCar.Details();
myCar._name = "myCar1";


Car audi = new Car("Audi A4", 250, "Dark blue");
audi.Details();

Car bmw = new Car("Bmw 5", 225, "Blue");
bmw.Details();

 



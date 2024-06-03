using Section_9._5___Intro_Interfaces;

// Ticket objekter med duration istancieres
Ticket t1 = new Ticket(10);
Ticket t2 = new Ticket(20);

// Tjek om t2 har samme durationInHours som t1
Console.WriteLine(t2.Equals(t1));


// Tjek om t2 har forskellige durationInHours end t1
Console.WriteLine(!(t2.Equals(t1)));



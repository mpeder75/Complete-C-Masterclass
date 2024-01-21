
// int i = 0 --> (counter variabel) counter variabel, hvor vi starter (starter på 0)

// i < 10    --> (condition) Hviklen condition skal der til for at hoppe ud af for loop (exit før 10)

// i++       --> in/decrementer, bruges til at tælle op/ned på i (i < 10) 



// loop forlæns fra 0 til 0

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}

// loop baglæns fra 9 til 0

for(int y = 9; y > 0; y--)
{
    Console.WriteLine($"y: {y}");
}


// increment med 5 for hver iteration

for (int j = 0; j < 50; j += 5)
{
    Console.WriteLine(j);
}


// loop der kun printer odd numbers fra 0 til 20

for (int x = 0; x <= 20; x++)
{
    if (x % 2 != 0)
    {
        Console.WriteLine($"number {x} is an odd number");
    }
}



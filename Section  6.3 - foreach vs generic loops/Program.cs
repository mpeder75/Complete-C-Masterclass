// BRUG:
// foreach: når man blot skal loop igennen, uden at manipulere
// for loop: når man her behov for kontrol, som hopper iteration over, iterere baglæns
// while: når man ikke ved hvor mang gange man vil loope igennem

//! foreach
// printe hvert nummer fra array
int[] myArray = { 1, -2, 3, 4, 5 };

// i er iterationen
// 1=0
// i=1...

// in myArray -> angiver i hvilken collection der skal loopes

// dvs. når i = 2 -> printes "index have value: -2"
foreach (int number in myArray)
{
    Console.WriteLine("index have value: " + number);
}


//! for loop
// for loop er mere fleksibel end foreach loops

// springe hver anden iteration over

for (int i = 0; i < myArray.Length; i += 2)
{
    Console.WriteLine("skipping every other index " + myArray[i]);
}


//! While loop
// bedst brugt når man ikke ved hvor mange gange man skal loope

// loope indtil bruger inputter exit key
string input;
do
{
    Console.WriteLine("Enter valid number");
    input = Console.ReadLine();
} while (!int.TryParse(input, out _));
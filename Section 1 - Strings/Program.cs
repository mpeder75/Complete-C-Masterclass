
//! Declare string variabel (datatype, navn)
string myName = "Michael";

string message = "My name is " + myName;

Console.WriteLine(myName);


// ------------- String uppercase/lowercase ---------------------------------------------------------

// konverter til små bogstaver
string lowerCase = myName.ToLower();
Console.WriteLine("lower case " + lowerCase);

// konverter til store bogstaver
string upperCase = myName.ToUpper();
Console.WriteLine("upper case " + upperCase);



// ------------- String Concat ---------------------------------------------------------------

int age = 31;
string name = "Alfonso";
string city = "Barcelona";

Console.WriteLine("My name is " + name + " and im " + age + " years old");


// ------------- String Formatting -------------------------------------------------------------

Console.WriteLine("Hello my name is {0}, I am {1} years old. I live in {2}", name, age, city);


// ------------- String Interpolation ----------------------------------------------------------

Console.WriteLine($"Hello, my name is {name}, I am {age} years old. I live in {city}");


// ------------- String verbantime ----------------------------------------------------------
//! Bruges til ex. lokation - @ bruges - nu slipper man med at  skulle bruge \\ i fil lokation

Console.WriteLine(@"C:\UserDesktop\Super CoolDog.png");


// ------------- String substring ----------------------------------------------------------
//! returnere alt tekst EFTER det index man giver - Mycar - her returneres car
string myVeichle = "Mycar";
Console.WriteLine(myVeichle.Substring(2));


// ------------- String trim ----------------------------------------------------------
//! Fjerner whitespace

string myString = "  Bob   ";
Console.WriteLine(myString.Trim());


// ------------- String IndexOf() ------------------------------------------------------

int index = myVeichle.IndexOf('M');
Console.WriteLine(index);

if (index == -1)
{
    Console.WriteLine("M is not in the word");
}
else
{
    Console.WriteLine("M is in the string");
}


// ------------- String special chars ------------------------------------------------------

string s1 = "this is a \"string\" with a slash / and a colon : and a baclslash \\ ";
Console.WriteLine(s1);


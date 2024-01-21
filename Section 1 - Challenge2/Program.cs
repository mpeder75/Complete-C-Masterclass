/*
Let’s create another console application for more practice.
This application asks the user to input a string in the first line like “Enter a string here: ”.
In the Second Line, it should ask for the character to search in the string which you have entered in the first line like 
“Enter the character to search: ”
On the third line, it should write the index of the first occurrence of the searched character from the string.

Now on concatenation...
It should then ask to enter the first name and once the name is written and the enter button is pressed, 
it should ask to enter the last name.
It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". 
Output can be different in your case. Try to store the full name in a variable, before displaying it.   
*/

Console.WriteLine("Enter a string");
string input = Console.ReadLine();
Console.WriteLine("WHICH CHAR SHOULD I SEARCH FOR? ");
string toSearchFor = Console.ReadLine();

Console.WriteLine("that char is on index " + input.IndexOf(toSearchFor));

Console.WriteLine("Enter firast name");
string firstName = Console.ReadLine();
Console.WriteLine("Enter last name");
string lastName = Console.ReadLine();

string fullName = firstName + " " + lastName;
Console.WriteLine($"Ypour full name is: {fullName}");
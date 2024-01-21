/*
Write two new methods:

LowUpper method will take a string as input, create lower- and uppercase copies, and return the result of their join.

Example:

"lol" string will produse "lolLOL".

The Count method also will take a string, but it will not return. It only will print "The amount of characters is X." with X replaced with the actual amount of characters in the string on another line.

Example:

"lol" string will print "The amount of characters is 3.".

Alert!

Both of them should be static and public. So add "static" and "public" keywords like those written below for the Run method.

The result of execution for the default string should be:

 */

Console.WriteLine(LowUpper("Bob"));
Count("Hansen");

static string LowUpper(string input)
{
    string lowerString = input.ToLower();
    string upperString = input.ToUpper();
    return lowerString + upperString;
}

static void Count(string input)
{
    int stringLength = input.Length;
    Console.WriteLine(stringLength);
}
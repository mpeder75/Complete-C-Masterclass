/*

In this challenge you will deepen your understanding for methods.
Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: 
"Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. 
So the method will need a parameter (decide which DataType will be best). 

Greet all your three friends. 
 
*/


string name1 = "Bob";
string name2 = "Paul";
string name3 = "John";

GreetFriend(name1, name2, name3);

static void GreetFriend(string name1, string name2, string name3)
{
    Console.WriteLine($"Hi {name1}, {name2}, {name3} my friends!");
}


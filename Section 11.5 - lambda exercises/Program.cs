/*
Exercise 1: Basic Lambda Expression
Write a lambda expression that takes two integers as parameters and returns their sum.

csharp
Copy code
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(5, 7));  // Output: 12
 */

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(5, 7));

/*
Exercise 2
Write a lambda expression that filters even numbers from a list of integers.
*/

List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var sortedIntegers = myList.Where(x => x % 2 == 0);

foreach(var numbers in sortedIntegers)
{
    Console.WriteLine(numbers);
}

/*
Exercise 3
Develop a lambda expression to find the maximum and minimum number in an array.
*/

int[] myArray = new int[] {1,2,3,4,5,6,7,8,9};

int maxNumber = myArray.Max(x => x);
int minNumber = myArray.Min(x => x);

Console.WriteLine($"Max number is {maxNumber} min number is {minNumber}");

/*
Exercise 4
Compose a lambda expression to concatenate two strings.
*/

string str1 = "Hello";
string str2 = "World";

Func<string, string, string> concatanate = (s1, s2) => s1 + s2;

string result = concatanate(str1, str2);

Console.WriteLine(result);



/*
Exercise 5
Craft a lambda expression that squares each element in a list of integers.
*/

List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

List<int> squaredNumbers = numbers1.Select(x => x * x).ToList();

int count = 1;
foreach(var num in squaredNumbers)
{
    Console.WriteLine($"Number {count} is {num}");
    count++;
}
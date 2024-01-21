
int num1 = 5;
int num2 = 3;
int num3;


// Unary operators
num3 = -num1;
Console.WriteLine($"num3 is {num3}");

// negering !
bool isSunny = true;
Console.WriteLine($"Is it sunny? {!isSunny}");


// Increment & decrement operators (pre og post)
int x = 4;
Console.WriteLine("x++: {0}", x++); // after this statement x = 5 (prints x = 4)
Console.WriteLine("++x: {0}", ++x); // before x = 5, after x = 6  (prints x = 6)


int y = 4;
Console.WriteLine("y--: {0}", y--); // after this statement y = 3 (prints y = 4)
Console.WriteLine("--y: {0}", --y); // before y = 4, after y = 2 (prints y = 2)


// Multiplikation, Division, Substraktion, Addition
int multiplication = num1 * num2; 
int diviosion =      num1 / num2; 
int substraktion =   num1 - num2; 
int addition =       num1 + num2; 


// modulo operator - returnere resten ved division af to tal
int moduloDivision = num1 % num2;


// relational and type operators
bool isLower;
isLower = num1 < num2;
Console.WriteLine($"is num1 lower than num2? {isLower}");


// Equality operator (= assigment operator) (== comperator operator)
bool isEqual;
isEqual = num1 == num2;
Console.WriteLine($"is num1 equal to num2? {isEqual}");

isEqual = num1 != num2;
Console.WriteLine($"is num1 not equal to num2? {isEqual}");


// Conditional operators
bool isLowerAndSunny;

isLowerAndSunny = isLower && isSunny;
Console.WriteLine(isLowerAndSunny);

isLowerAndSunny = isLowerAndSunny || isSunny;
Console.WriteLine(isLowerAndSunny);

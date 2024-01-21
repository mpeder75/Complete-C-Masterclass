// Method der lægger to tal sammen

Console.WriteLine("Adding: " + Add(5, 5));

int Add(int num1, int num2)
{
    return num1 + num2;
}


// Eksempel 1: Method der tager imod to tal og ganger disse sammen oig returnere til invoker

Console.WriteLine("Multiplying: " + MultiplyNum(20, 2));

int MultiplyNum(int a, int b)
{
    return a * b;
}




// Eksempel 2: Method der dividere 2 tal

Divide(2.5, 2.0);
double Divide(double a, double b)
{
    return a / b; 
}




// Eksempel 3: Method der printer navn
Console.WriteLine("Enter name");
string name = Console.ReadLine();

PrintName(name);

void PrintName(string name)
{
    Console.WriteLine($"You entered {name}");
}




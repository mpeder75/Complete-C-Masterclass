//! En void method returnere ikke noget, fx. en beregning


// void method kaldes

WriteSomething();
WriteSometrhingSpecific("Poul");



// void method der ikke returnere, men printer blot 
void WriteSomething()
{
    Console.WriteLine("Hello, I am called from a method");
}



// Void method der printer passet navn 
void WriteSometrhingSpecific(string name)
{
    Console.WriteLine($"Hello, my name is {name}");
}






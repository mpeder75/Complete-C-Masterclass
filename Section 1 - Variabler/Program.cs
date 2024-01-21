
//! Declare variabel (datatype, navn)
int num1;

//! Assign variabel en værdi
num1 = 3;

//! Declare og assign på samme tid
int num2 = 10;

//! Declare flere variabler på samme tid
int myNum1, myNum2, myNum3;

//! Assigne flere variabler på samme tid
myNum1 = 1; myNum2 = 2; myNum3 = 3;

// ------------ Lægge to variabler sammen --------------------------------

//! Lægge de to variabler sammen
int sum = num1 + num2;
Console.WriteLine(sum);

// -----------------------------------------------

//! Concat
Console.WriteLine($"Num1 + Num2 is = {sum}");


// ------------ Double - Flest decimaler ----------------------------------

double d1 = 3.1415;
double d2 = 5.1;
double dDiv  = d1 / d2;
Console.WriteLine("d1 / d2 is " + dDiv);

// ------------ Float ----------------------------------------------------

float f1 = 3.1415f;
float f2 = 5.1f;
float fDiv = f1 / f2;
Console.WriteLine("f1 / f2 is " + fDiv);




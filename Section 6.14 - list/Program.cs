
// Declare list
var numbers = new List<int>();           //? liste af typen int


// Add
numbers.Add(7);  // tilføjer 7 til Listen
numbers.Add(14);
numbers.Add(5);

// getting a element
int value = numbers[0];
Console.WriteLine("Value at index 0 is: " + value);


// Count - hvor mange elementer er der i klist
int numOfElements = numbers.Count;
Console.WriteLine("Number of elements in list:" + numOfElements);


// Remove() - sletter element med værdi 7 fra liste
numbers.Remove(7);


// RemoveAt() - sletter et element i et specefikt index (sletter 14)
numbers.RemoveAt(0);


// clear() - slette alle elementer i list
numbers.Clear();


// loops - foreach
var myNumbers = new List<int> { 5,10,15,20,25,30,35,40 };

foreach (int element in myNumbers)
{
    Console.WriteLine("looping from foreach " + element);
}


// loops - for-loop
var numberList = new List<int> {50, 40, 30, 20, 10};

for (int i = 0; i < numberList.Count; i++)
{
    Console.WriteLine("Looping from for-loop " + numberList[i]);
}


using System.Collections;

//! ArrayList - kan opbevare alle datatyyper, ptimitiver & objekter

// declare arraylist
ArrayList myArrayList = new ArrayList();            //? med uendedligt plads til  objjekter
ArrayList myArrayList1 = new ArrayList(100);        //? med plads til 100 objekter


// add - tilføje primitiver eller objekter til arraylist
myArrayList.Add(25);
myArrayList.Add("Hello");
myArrayList.Add(13.37);
myArrayList.Add(13);
myArrayList.Add(128);
myArrayList.Add(25.4);
myArrayList.Add(13);


// remove() - metode der sletter element med specifik værdi (fjerner den føste den finder)
myArrayList.Remove(13);

// removeAt() - slette element på et specifikt index (her slettes elementet på index 0)
myArrayList.RemoveAt(0);

// count - hvor mange elementer er der i arrayList
Console.WriteLine($"num of elements is: {myArrayList.Count}");

// loope igennem arrayList - her tjekkes om objektet er af typen int og lgges sammen i result
double sum = 0;

foreach(object obj in myArrayList)
{
    if(obj is int)
    {
        sum += Convert.ToDouble(obj);  // man converter til double, da datatypen fuindet er int
    } else if(obj is double)
    {
        sum += (double)obj;            // her er fundet datatype double, derfor castes der blot
    }
    else if(obj is string) 
    {
        Console.WriteLine(obj);
    }
}

Console.WriteLine("Sum is " + sum);

// .Clear() - tømmer arraylist for elementer
myArrayList.Clear();

// contains() - søg eftger noget i arraylist, returnere bool
bool found = myArrayList.Contains("Mads");





// generisk IEnumerable variabel der tager hvilken som helst type af int
IEnumerable<int> unknownCollection;

unknownCollection = GetCollection(1);
foreach (var item in unknownCollection)
{
    Console.WriteLine(item);
}


// -----------------------------------------------------------------
Console.WriteLine(new string('-', 60));

unknownCollection = GetCollection(2);
foreach (var myItem in unknownCollection)
{
    Console.WriteLine(myItem);
}

// -----------------------------------------------------------------
Console.WriteLine(new string('-', 60));


unknownCollection = GetCollection(3);
foreach(var item in unknownCollection)
{
    Console.WriteLine(item);
}




static IEnumerable<int> GetCollection(int option)
{
    List<int> numbersList = new List<int>() { 1,2,3,4,5};

    Queue<int> numbersQueue = new Queue<int>();
    numbersQueue.Enqueue(6);
    numbersQueue.Enqueue(7);
    numbersQueue.Enqueue(8);
    numbersQueue.Enqueue(9);
    numbersQueue.Enqueue(10);
    
    if (option == 1)
    {
        return numbersList;
    } else if (option == 2)
    {
        return numbersQueue;
    } else {
        return new int[] { 20, 21, 22, 23 };
    }

    return null;
}
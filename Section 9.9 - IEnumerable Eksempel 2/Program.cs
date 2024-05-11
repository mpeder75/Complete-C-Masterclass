
List<int> numbersList = new List<int> { 8,7,6 };
int[] numberArray = new int[] { 1,7,1,3};

Console.WriteLine(new string('-', 65));

CollectionSum(numbersList);

Console.WriteLine(new string('-', 65));

CollectionSum(numberArray);




// static void CollectionSum, der kan tage imod HVILKEN som helt collection
static void CollectionSum(IEnumerable<int> anyCollection)
{
    // metode tager værdierne i passet collection og summere dem op
    int sum = 0;
    foreach (var num in anyCollection)
    {
        sum += num;
    }

    Console.WriteLine($"Sum is: {sum}");
}
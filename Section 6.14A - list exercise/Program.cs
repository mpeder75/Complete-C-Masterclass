/*
 Write a method that returns a list of EVEN integer numbers between 100 and 170 (inclusive).
 
*/

List<int> result = Solution();

foreach(int count in result)
{
    Console.WriteLine(count);
}



static List<int> Solution()
{
    List<int> myList = new List<int>();

    for (int i = 99; i <= 170; i++)
    {
        if (i % 2 == 0)
        {
           myList.Add(i);
        }
    }

    return myList;   
}

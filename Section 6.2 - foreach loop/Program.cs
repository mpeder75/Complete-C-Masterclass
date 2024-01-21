
int[] nums = new int[10];


// bruge for loop til at populate array
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = i + 10;
    Console.WriteLine($"element {i} is: {nums[i]}");
}


// bruge foreach til at populate array
// k er værdien af nums i et specefikt index
// først er k = 0
// så k = 1 ....
int counter = 0;
foreach (int k in nums)
{
    Console.WriteLine($"foreach element {counter} is: {k}");
    counter++;
}


// bruge foreach uden counter
foreach (int x in nums)
{
    Console.WriteLine();
}


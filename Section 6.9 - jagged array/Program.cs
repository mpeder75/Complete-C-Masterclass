//! Jagged array er et array der opbevare andre arrays


// jagged array declares, hvor der angives det skal indeholde 3 arrays
int[][] jaggedArray = new int[3][];

// assign værdier
jaggedArray[0] = new int[] {1,2,3,4,5};  // på pos 0 er der et array med 5 indexes
jaggedArray[1] = new int[] {2,2,2,2,2};
jaggedArray[2] = new int[] {9,8,7,6,5};

// declare og assign jagged array på EEN gang
int[][] jaggedArray2 = new int[][]
{
    new int[] {1,2,3,4,5},
    new int[] {5,4,3,2,1}
};

Console.WriteLine("value in the middle of first array " + jaggedArray2[0][2]);


// Exercise: print every values in the jagged array
for (int i = 0; i < jaggedArray2.Length; i++)
{
    Console.WriteLine("Element {0}", i);

    for (int j = 0; j < jaggedArray2[i].Length; j++)
    {
        Console.WriteLine("{0} ", jaggedArray2[i][j]);
    }
}


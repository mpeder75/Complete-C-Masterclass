
int[,] matrix =
{
    { 1, 2, 3, },  // row 0
    { 4, 5, 6,},   // row 1
    { 7, 8, 9,}    // row 2
};


// loope igennem 2D array med foreach
foreach (var item in matrix)
{
    Console.Write(item + " ");
}


// loope igennem 2D array med nested for-loop
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i, j]);
    }
}
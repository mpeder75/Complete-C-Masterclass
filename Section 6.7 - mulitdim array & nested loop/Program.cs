int[,] matrix =
{
    { 1, 2, 3, },  // row 0
    { 4, 5, 6,},   // row 1
    { 7, 8, 9,}    // row 2
};


// Kun printe lige elementer ud
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] % 2 == 0)
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
}


// Kun printe lige elementer ud
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            Console.Write(matrix[i, j] + " ");
        } else
        {
            Console.Write(" ");
        }        
    }
    Console.WriteLine("");
}



// printe 3,5,7
for(int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
{   
    Console.Write(matrix[i, j] + " ");            
    
}
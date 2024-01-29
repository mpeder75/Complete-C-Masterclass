//! -------------------- 2D arrays --------------------

// assign værdier
int[,] array2D = new int[,]
{
    {1,2,3 },  // row 0
    {4,5,6},   // row 1
    {7,8,9}    // row 2
};

// tilgå værdien der er i midten af 2d array
Console.WriteLine("central value is" + array2D[1,1]);

Console.WriteLine($"2,0 gives us -> {array2D[2,0]}");


// Exercise: ændre værdien "four" til chicken
string[,] array2DString = 
{
    {"one", "two" },
    {"three", "four" },
    {"five", "six"}
};

array2DString[1, 1] = "Chicken";
Console.WriteLine(array2DString[1, 1]);

// find ud af hvor mange dimensions et array har
int dimensions = array2DString.Rank;
Console.WriteLine("arrayDString has " +dimensions + " dimensions");


//! -------------------- 3D arrays --------------------

//3-Dimensions are more complex, but the Concept is the same
string[,,] array3D = new string[,,]
{
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },
                {
                    {"200", "201", "202" },
                    {"210", "211", "212" },
                    {"220", "221", "222" }
                },
                {
                    {"Hi", "I", "am" },
                    {"also", "part", "of" },
                    {"the", "3-dimensional", "array" }
                }
};


// access the Value "201"
Console.WriteLine(array3D[2, 0, 1]);

// tilgå værdien 'Hi'
Console.WriteLine(array3D[3, 0, 0]);




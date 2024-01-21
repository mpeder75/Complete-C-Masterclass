/*
Today your task is to practice the use of loops. 

There are two methods you have to fill:
    in the ForLoop method you have to  print on a new line each value from -3 to 3 included using the for loop;
    in the WhileLoop method you need to print values from 3 to -3 using the while loop;
 */


ForLoop();
WhileLoop();


static void ForLoop()
{
    for (int i = -3; i <= 3; i++)
    {
        Console.WriteLine($"Print from ForLoop: {i}");
    }    
}


static void WhileLoop()
{
    int counter = 3; 
    
    while ( counter >= -3 )
    {
        Console.WriteLine($"Print from While: {counter}");
        counter--;
    } 

}
/*
To pass the tests, your loop should skip all divisible by 3 values and stops running when i = 10.

Warning: You cannot touch the given parts of the code! You can add your conditions only inside the loop!

Warning2: This while loop is an infinite loop! 
To avoid it causing you issues we implemented the current if statement that you can find. 
This, with the proper solution in place, should not be needed anymore. 
Before running the tests, find a way to stop it without reaching the pre-placed break!

*/



CountLoop();

void CountLoop()
{
    bool isTrue = true;

    while (isTrue)
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i % 3 == 0)
            {               
                continue;
            }
            Console.WriteLine(i);
        }
        isTrue = false;
    }

}
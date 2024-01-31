/*
This time, you have to write only a checker for the game. 
It will be a method that takes a 2D array and returns a boolean. 
If there is a winner, it returns true otherwise false.

We use "X" and "O" as signs of our players. The empty places will be filled with numbers from 1 to 9.

You have to check 3 types of cases:
    horizontal;
    vertical;
    diagonal;

Hint: you can use more than one condition inside of one if, and don't hesitate to use loop;
*/

 static bool Checker(string[,] board)
{
    // here we perform horizontal and vertical checks
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            return true;
        if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            return true;
    }

    // here diagonal checks 
    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        return true;
    if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        return true;
    return false;

}
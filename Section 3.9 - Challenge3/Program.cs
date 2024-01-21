/*
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.

When ever that method is called, it should be checked if the score of the player is higher than the highscore, 
if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName  
should be written onto the console, 

if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.  
*/

int highScore = 300;
string highScorePlayer = "Poul";


RegisterPlayer();


void RegisterPlayer()
{
    Console.WriteLine("Enter name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter score");
    int sccore = int.Parse(Console.ReadLine());

    Check(sccore, name);
}


void Check(int playerScore, string playerName)
{
    if (playerScore > highScore )
    {
        highScore = playerScore;
        highScorePlayer = playerName;
        Console.WriteLine($"New highscore is {highScore}");
        Console.WriteLine($"Highscore holder is {highScorePlayer}");
    } else if (playerScore < highScore)
    {
        Console.WriteLine($"The old highsocre is {highScore} of {highScorePlayer} could not be broken");
    }
}
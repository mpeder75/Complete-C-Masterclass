
//! do while loope køre ALTID sin do kod-dele først, dvs. der tjekkes først bagefter i næste iteration

//! do while SKAl have en counter udenfor loopet


int counter = 0;
do
{
    Console.WriteLine(counter);
    counter++;
} 
while (counter < 5);



// Eksempel: med brugerinput, der printer allt navne ud til sidst

int lengthOfText = 0;

string wholeText = "";

do
{
    Console.WriteLine("Enter name of a friend");
    string nameOfAFriend = Console.ReadLine();

    int currentLength = nameOfAFriend.Length;

    lengthOfText += currentLength;

    wholeText += nameOfAFriend;
    
} while (lengthOfText < 20);

Console.WriteLine("All the names combined" + wholeText);

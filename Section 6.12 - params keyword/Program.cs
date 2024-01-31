// for at se param/perloaded metrh ods
// 1. stå med curser i ()
// 2. tryk ctrl+shift+space
// 3. brug pil op/pil ned

//! params keyword, tillader at passe så mange parametre til æen method som man vil

Params("This", "is", "a", "very", "long", "and", "windy", "string", ",", "it", "just", "continues");


// method der bruger params til string array
static void Params(params string[] sentence)
{
    for (int i = 0; i < sentence.Length; i++)
    {
        Console.Write(sentence[i] + " ");
    }
}




//! params med objekter
int price = 20;
string name = "Bob";
double pi = Math.PI;
char at = '@';

ParamsMethod2(price, name, pi, at);

// method der bruger params til object array
static void ParamsMethod2(params object[] stuff)
{
    foreach (object obj in stuff)
    {
        Console.WriteLine(obj + " ");
    }
}




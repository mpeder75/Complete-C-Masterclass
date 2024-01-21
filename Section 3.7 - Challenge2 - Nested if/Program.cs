
Console.WriteLine("Enter name");
string name = Console.ReadLine();

Console.WriteLine("Enter password");
string password = Console.ReadLine();

string correctName = "Michael";
string correctPassword = "1234";

if (name.Equals(correctName))
{
    bool passIsValid = PasswordValid(password);
    if (passIsValid)
    {
        Console.WriteLine("Everything is OK");
    }
    else
    {
        Console.WriteLine("Password wrong");
    }
}
else
{
    Console.WriteLine("Name or password not correct ");
}

bool PasswordValid(string password)
{
    if (password.Equals(correctPassword))
    {
        return true;
    }
    else
    {
        return false;
    }
}
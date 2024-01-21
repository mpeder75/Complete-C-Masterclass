//! Nested if statement er et is taatement i et if statement osv....


bool isAdmin = false;
bool isRegistered = true;
string userName = "";

Console.WriteLine("Please enter uusername");
userName = Console.ReadLine();

if (isRegistered)
{
    Console.WriteLine("Hi there, registered user");

    if (userName != "")
    {
        Console.WriteLine($"Hi there, {userName}");

        if (userName.Equals("admin"))
        {
            Console.WriteLine("Hi there, Admin");
        }
    }
}

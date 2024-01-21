
//! Switch er ligesom If - MEN switch kan kun validere på EN variabel ad gangen

// HUSK break ved HVER case

int age = 25;

switch (age)
{
    case 15:
        Console.WriteLine("To young to party in the club");
        break;

    case 25:
        Console.WriteLine("Good to go");
        break;

    default:
        {
            Console.WriteLine("How old are you then?");
            break;
        }
}



// Challenge - reproduce switch as a if statement

if (age == 15)
{
    Console.WriteLine("To young to party in the club");
}
else if (age == 25)
{
    Console.WriteLine("Good to go");
}
else
{
    Console.WriteLine("How old are you then?");
}


// Switch with strings

string userName = "Denis";


switch (userName)
{

    case "Denis":
        {
            Console.WriteLine("bob");
            break;
        }
    case "Root":
        {
            Console.WriteLine("userName is Root");
            break;
        }
    default:
        {
            Console.WriteLine("userName unknown");
            break;
        }
}
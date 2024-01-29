//todo Delegate basic

List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatole" };


Console.WriteLine("----- List before ---- ");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Filter metod passes til RemoveALl metrd
names.RemoveAll(Filter);



Console.WriteLine("----- List after ---- ");
foreach (string name in names)
{
    Console.WriteLine(name);
}



// returner om string indeholder bogstavet 'i'
static bool Filter(string s)
{
    // return method returnere en bool, som method returnere
    return s.Contains("i");
}
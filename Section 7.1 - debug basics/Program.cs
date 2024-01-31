//todo debugging tutorial

// program der udfra liste af navne, finder de 3 korteste navne

var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
var partyFriends = GetPartyFriends(friends, 3);

foreach (var name in partyFriends)
{
    Console.WriteLine(name);
}

static List<string> GetPartyFriends(List<string> list, int count)
{
    var partyFriends = new List<string>();

    while (partyFriends.Count < count)
    {
        var currentFriend = GetPartyFriend(list);
        partyFriends.Add(currentFriend);
        list.Remove(currentFriend);
    }
    return partyFriends;
}
 static string GetPartyFriend(List<string> list)
{
    string shortestName = list[0];
    for (var i = 0; i < list.Count; i++)
    {
        //! intentional logical bug here
        if (list[i].Length > shortestName.Length)
        {
            shortestName = list[i];
        }
    }
    return shortestName;
}

Members member1 = new Members();

member1.Introduce(true);




class Members
{
    // member - private
    private string _memberName;
    private string _jobTitle;
    private int _salary;

    // member - public
    public int age;
    public int salary;  

    // member - propertie
    public string JobtTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    // member - method
    public void Introduce(bool isFriend)
    {
        if (isFriend)
        {
            SharingPrivateInfo();            
        }
        else
        {
            Console.WriteLine("Talk around");
        }
    }

    private void SharingPrivateInfo()
    {
        Console.WriteLine("My name is: " + _memberName);
        Console.WriteLine("My title is: " + _jobTitle);
        Console.WriteLine("My salary is: " + _salary);
    } 

    // member - constructor
    public Members()
    {
        age = 30;
        _memberName = "Lucy"; ;
        _salary = 60000;
        _jobTitle = "Developer";
        Console.WriteLine("Object created");
    }
}

 
/* 
The main of this exercise is to create 3 constructors for the class Phone:

default constructor that sets all values to "unknown";

constructor that takes 2 arguments (company and model) and sets them respectively. 
The ReleaseDay should be set to "unknown";

constructor with 3 arguments (company, model, and release day);
 */

Phone myPhone = new Phone();
myPhone.Details();


internal class Phone
{
    public string Company;
    public string Model;
    public string ReleaseDay;

    public Phone()
    {
        Company = "unknown";
        Model = "unknown";
        ReleaseDay = "unknown";
    }

    public Phone(string company, string model)
    {
        Company = company;
        Model = model;
        ReleaseDay = "unknown";
    }

    public Phone(string company, string model, string releaseday)
    {
        Company = company;
        Model = model;
        ReleaseDay = releaseday;
    }

    public void Details()
    {
        Console.WriteLine($"{Model}, {Company}, {ReleaseDay}");
    }

}
namespace ConsoleApp1;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IndexNumber { get; set; }
    public int PhoneNumber { get; set; }

    public string ShowFullName()
    {
        return LastName + " " + FirstName;
    }
}

namespace ConsoleApp1;

public class Extensions
{
    public static int IntParser(string text, int minValue, int maxValue)
    {
        int number;
        if (int.TryParse(text, out number))
        {
            if (number >= minValue && number <= maxValue)
            {
                return number;
            }
            else
            {
                return -1;
            }
        }
        else 
        { 
            return -2; 
        }
    }
    public static string StudentData(Student student)
    {
        return $"{student.LastName}, {student.FirstName}, {student.PhoneNumber}, {student.IndexNumber}";
    }
}

namespace ConsoleApp1;

public class StudentService
{
    public static Student AddNewStudent()
    {
        Student student = new Student();

        Console.WriteLine("Podaj nazwisko: ");
        student.LastName = Console.ReadLine();

        Console.WriteLine("Podaj imię: ");
        student.FirstName = Console.ReadLine();

        Console.WriteLine("Podaj numer telefonu: ");
        student.PhoneNumber = Extensions.IntParser(Console.ReadLine(), 111111111, 999999999);

        Console.WriteLine("Podaj numer indeksu: ");
        student.IndexNumber = Console.ReadLine();

        return student;
    }
    public static void GetStudent(List<Student> studentList) 
    {
        Console.WriteLine("\n");

        for (int i = 0; i < studentList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {studentList[i].ShowFullName()}");
        }

        Console.WriteLine("\n");
    }
    public static Student GetStudentData(List<Student> studentList)
    {
        Console.WriteLine("Podaj indeks studenta: ");
        string indeks = Console.ReadLine();

        foreach (Student student in studentList)
        {
            if (indeks == student.IndexNumber)
            {
                return student;
            }
        }
        return null;
    }

}

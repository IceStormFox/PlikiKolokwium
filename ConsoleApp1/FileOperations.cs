namespace ConsoleApp1;

public class FileOperations
{
    public static void Save(List<Student> studentList)
    {
        try
        {
            using (StreamWriter streamWriter = new StreamWriter("students.txt"))
            {
                streamWriter.WriteLine("Nazwisko, imię, telefon, indeks");
                streamWriter.WriteLine();
                foreach (Student student in studentList) 
                {
                    streamWriter.WriteLine(Extensions.StudentData(student));
                }
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Błąd obsługi pliku: " + ex.Message);
        }
    }
    public static void Read()
    {

    }
    public void Delete() 
    {

    }
    public void Edit()
    {

    }
}

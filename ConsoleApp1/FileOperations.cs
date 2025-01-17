using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public class FileOperations
{
    private static readonly string _path = "students.txt";
    public static void Save(List<Student> studentList)
    {
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                streamWriter.WriteLine("Nazwisko, imię, telefon, indeks");

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
    public static List<Student> Read()
    {
        List<Student> studentList = new List<Student>();
        try
        {
            using (StreamReader streamReader = new StreamReader(_path))
            {
                //Przykładowe dane:

                //nazwisko, imie, numer_telefonu, numer_indexu
                //Kowalski, Jan, 123123123, 4321
                //Barczak, Alan, 987987987, 0987

                string line;

                streamReader.ReadLine();

                while ((line = streamReader.ReadLine()) != null) 
                {

                    Student student = new Student();

                    student.LastName = line.Split(", ")[0];
                    student.FirstName = line.Split(", ")[1];
                    student.PhoneNumber = int.Parse(line.Split(", ")[2]);
                    student.IndexNumber = line.Split(", ")[3];

                    studentList.Add(student);
                }
            }
            return studentList;
        }
        catch (Exception ex) 
        { 
            Console.WriteLine(ex.Message);
            return new List<Student>();
        }
        
    }
    public static string Delete() 
    {
        List<Student> studentList = new List<Student>();
        string message;

        using (StreamReader streamReader = new StreamReader(_path))
        {
            string liniaOdczytana = streamReader.ReadLine();

            if (liniaOdczytana == null) { message = "Plik jest pusty. Proszę najpiew stworzyć plik."; return message; }
        }

        studentList = Read();

        if (studentList.Count == 0) { message = "Lista studentów jest pusta"; return message; }

        Console.WriteLine("Lista studentów: ");
        foreach (Student student in studentList) 
        {
            Console.WriteLine($"{Extensions.StudentData(student)}");
        }

        Console.WriteLine("Podaj indeks studenta do usunięcia: ");
        string indexNumber = Console.ReadLine();

        foreach (Student student in studentList)
        {
            if (student.IndexNumber == indexNumber)
            {
                studentList.Remove(student);
                Save(studentList);
                message = "Usunięto studenta o indeksie " + indexNumber;
                return message;
            }            
        }
        message = "Indeks nie istnieje.";
        return message;

    }
    public void Edit()
    {

    }
}

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        int choice;
        List<Student> studentList = new List<Student>();

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Dodaj studenta");
            Console.WriteLine("2. Wyświetl studentów");
            Console.WriteLine("3. Wyświetl dane studenta");
            Console.WriteLine("4. Zapisz do pliku");
            Console.WriteLine("5. Wczytaj listę studentów z pliku");
            Console.WriteLine("6. Usuń studenta z pliku");
            Console.WriteLine("7. Wyjście");

            var menuChoice = Console.ReadLine();
            choice = Extensions.IntParser(menuChoice, 1, 7);
            switch (choice)
            {
                case 1: 
                    var student = StudentService.AddNewStudent(); 
                    studentList.Add(student); 
                    break;
                case 2: StudentService.GetStudentList(studentList); break;
                case 3: Console.WriteLine($"{Extensions.StudentData(StudentService.GetStudentData(studentList))}"); break;
                case 4: FileOperations.Save(studentList); break;
                case 5: studentList = FileOperations.Read(); break;
                case 6: Console.WriteLine(FileOperations.Delete()); studentList = FileOperations.Read(); break;
                case 7: return;
            }
        }
        while (choice != 7);
    }
}
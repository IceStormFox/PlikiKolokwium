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
            Console.WriteLine("5. Czytaj z pliku");
            Console.WriteLine("6. Wyjście");

            var menuChoice = Console.ReadLine();
            choice = Extensions.IntParser(menuChoice, 1, 6);
            switch (choice)
            {
                case 1: 
                    var student = StudentService.AddNewStudent(); 
                    studentList.Add(student); 
                    break;
                case 2: StudentService.GetStudentList(studentList); break;
                case 3: Console.WriteLine($"{Extensions.StudentData(StudentService.GetStudentData(studentList))}"); break;
                case 4: FileOperations.Save(studentList); break;
                case 6: return;
            }
        }
        while (choice != 6);
    }
}
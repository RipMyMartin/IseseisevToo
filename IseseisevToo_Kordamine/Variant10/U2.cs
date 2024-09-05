using System;
using System.Linq;

class Student
{
    public string LastName { get; set; }
    public string GroupCode { get; set; }
    public int[] Grades { get; set; }

    public bool IsExpelled()
    {
        // Проверяем, что у студента по трем и более дисциплинам оценка 2
        return Grades.Count(grade => grade == 2) >= 3;
    }
}

class StudentManager
{
    public static void PrintExpelledStudents(Student[] students)
    {
        var expelledStudents = students.Where(s => s.IsExpelled()).ToArray();
        Console.WriteLine("Студенты, подлежащие отчислению:");
        foreach (var student in expelledStudents)
        {
            Console.WriteLine(student.LastName);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = {
            new Student { LastName = "Иванов", GroupCode = "A1", Grades = new[] { 2, 2, 3, 2, 4 } },
            new Student { LastName = "Петров", GroupCode = "B2", Grades = new[] { 3, 3, 4, 2, 5 } },
            new Student { LastName = "Сидоров", GroupCode = "C3", Grades = new[] { 2, 2, 2, 2, 2 } }
        };

        StudentManager.PrintExpelledStudents(students);
    }
}

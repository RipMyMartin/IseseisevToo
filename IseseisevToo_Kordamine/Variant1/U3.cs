using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GroupCode { get; set; }
    public int[] Grades { get; set; }

    public Student(string firstName, string lastName, string groupCode, int[] grades)
    {
        FirstName = firstName;
        LastName = lastName;
        GroupCode = groupCode;
        Grades = grades;
    }

    public bool IsEligibleForScholarship()
    {
        foreach (int grade in Grades)
        {
            if (grade < 4)
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName}, Группа: {GroupCode}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student("Иван", "Иванов", "A101", new int[] { 5, 4, 4, 5 }),
            new Student("Мария", "Петрова", "A102", new int[] { 3, 4, 5, 4 }),
            new Student("Алексей", "Сидоров", "A101", new int[] { 5, 5, 5, 5 })
        };

        Console.WriteLine("Студенты, которые получают стипендию:");
        foreach (var student in students)
        {
            if (student.IsEligibleForScholarship())
            {
                Console.WriteLine(student);
            }
        }
    }
}

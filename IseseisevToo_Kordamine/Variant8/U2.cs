using System;

class LongestSurnameFinder
{
    public static string FindLongestSurname(string[] surnames)
    {
        string longestSurname = surnames[0];

        for (int i = 1; i < surnames.Length; i++)
        {
            if (surnames[i].Length > longestSurname.Length)
            {
                longestSurname = surnames[i];
            }
        }

        return longestSurname;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] surnames = { "Иванов", "Петров", "Сидоров", "Антонова", "Александрова" };

        Console.WriteLine("Массив фамилий: " + string.Join(", ", surnames));

        string longestSurname = LongestSurnameFinder.FindLongestSurname(surnames);
        Console.WriteLine($"Самая длинная фамилия: {longestSurname}");
    }
}

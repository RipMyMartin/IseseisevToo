using System;

class SurnameSorter
{
    public static void SortAndPrintSurnames(string[] surnames)
    {
        Array.Sort(surnames);
        Console.WriteLine("Отсортированный список фамилий:");
        foreach (string surname in surnames)
        {
            Console.WriteLine(surname);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите список фамилий через запятую: ");
        string input = Console.ReadLine();

        string[] surnames = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        SurnameSorter.SortAndPrintSurnames(surnames);
    }
}

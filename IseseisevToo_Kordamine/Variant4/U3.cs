using System;

class StringSorter
{
    public static string SortAndReverse(string input)
    {
        // Сортируем символы по их коду
        char[] sortedArray = input.ToCharArray();
        Array.Sort(sortedArray);

        // Переворачиваем строку
        Array.Reverse(sortedArray);

        return new string(sortedArray);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = StringSorter.SortAndReverse(input);
        Console.WriteLine($"Строка после сортировки и реверса: {result}");
    }
}

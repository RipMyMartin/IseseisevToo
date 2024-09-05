using System;
using System.Linq;

class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        // Приводим строку к нижнему регистру и удаляем все пробелы
        string cleanString = new string(input.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

        // Проверяем, является ли строка палиндромом
        return cleanString.SequenceEqual(cleanString.Reverse());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        bool isPalindrome = PalindromeChecker.IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }
}

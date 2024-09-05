using System;

class VowelCounter
{
    // Массив гласных букв латинского алфавита
    private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    public static double CountVowelPercentage(string input)
    {
        int totalChars = 0;
        int vowelCount = 0;

        // Приводим строку к нижнему регистру
        input = input.ToLower();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                totalChars++;
                if (Array.Exists(Vowels, v => v == c))
                {
                    vowelCount++;
                }
            }
        }

        // Вычисление процента вхождения гласных
        return totalChars > 0 ? (vowelCount / (double)totalChars) * 100 : 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        double percentage = VowelCounter.CountVowelPercentage(input);
        Console.WriteLine($"Процент вхождения гласных букв: {percentage:F2}%");
    }
}

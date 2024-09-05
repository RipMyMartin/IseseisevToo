using System;

class NameAnalyzer
{
    public static void AnalyzeName(string name)
    {
        // Массив гласных букв
        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'a', 'e', 'i', 'o', 'u', 'y' };
        int vowelCount = 0;
        int consonantCount = 0;

        char[] nameLetters = name.ToLower().ToCharArray();

        Console.WriteLine("Буквы в имени:");
        foreach (char letter in nameLetters)
        {
            Console.Write(letter + " ");
            if (char.IsLetter(letter))
            {
                if (Array.Exists(vowels, vowel => vowel == letter))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Количество гласных: {vowelCount}");
        Console.WriteLine($"Количество согласных: {consonantCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        NameAnalyzer.AnalyzeName(name);
    }
}

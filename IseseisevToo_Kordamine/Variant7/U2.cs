using System;

class WordFinder
{
    public static bool ContainsWord(string text, string word)
    {
        // Приводим строку и слово к нижнему регистру
        string lowerText = text.ToLower();
        string lowerWord = word.ToLower();

        return lowerText.Contains(lowerWord);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.Write("Введите слово для поиска: ");
        string word = Console.ReadLine();

        bool found = WordFinder.ContainsWord(text, word);

        if (found)
        {
            Console.WriteLine($"Слово \"{word}\" присутствует в тексте.");
        }
        else
        {
            Console.WriteLine($"Слово \"{word}\" отсутствует в тексте.");
        }
    }
}

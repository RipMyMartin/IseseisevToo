using System;

class TextAnalyzer
{
    public string InputString { get; set; }

    public TextAnalyzer(string input)
    {
        InputString = input;
    }

    public int CountWords()
    {
        // Разделение строки по пробелам и подсчет количества слов
        string[] words = InputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public int CountSpaces()
    {
        // Подсчет пробелов в строке
        int spaceCount = 0;
        foreach (char c in InputString)
        {
            if (c == ' ')
            {
                spaceCount++;
            }
        }
        return spaceCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        TextAnalyzer analyzer = new TextAnalyzer(inputString);
        int wordCount = analyzer.CountWords();
        int spaceCount = analyzer.CountSpaces();

        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество пробелов: {spaceCount}");
    }
}

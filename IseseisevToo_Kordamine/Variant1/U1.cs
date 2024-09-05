using System;

class StringAnalyzer
{
    public string InputString { get; set; }

    public StringAnalyzer(string input)
    {
        InputString = input;
    }

    public double CalculateCharacterPercentage(char character)
    {
        int count = 0;
        foreach (char c in InputString)
        {
            if (c == character)
            {
                count++;
            }
        }

        return (double)count / InputString.Length * 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        Console.Write("Введите символ для подсчета: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        StringAnalyzer analyzer = new StringAnalyzer(inputString);
        double percentage = analyzer.CalculateCharacterPercentage(inputChar);

        Console.WriteLine($"Процент вхождения символа '{inputChar}' в строку: {percentage:F2}%");
    }
}

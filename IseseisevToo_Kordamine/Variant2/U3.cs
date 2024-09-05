using System;
using System.Linq;

class NumberAnalyzer
{
    public string Number { get; set; }

    public NumberAnalyzer(string number)
    {
        Number = number;
    }

    // Преобразование числа в массив цифр
    public int[] GetDigits()
    {
        return Number.Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    // Проверка на симметричность (палиндром)
    public bool IsSymmetrical()
    {
        return Number.SequenceEqual(Number.Reverse());
    }

    // Проверка на одинаковые цифры
    public bool AllDigitsAreSame()
    {
        return Number.All(c => c == Number[0]);
    }

    // Проверка на возрастание
    public bool IsIncreasing()
    {
        for (int i = 1; i < Number.Length; i++)
        {
            if (Number[i] <= Number[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Проверка на убывание
    public bool IsDecreasing()
    {
        for (int i = 1; i < Number.Length; i++)
        {
            if (Number[i] >= Number[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string inputNumber = Console.ReadLine();

        NumberAnalyzer analyzer = new NumberAnalyzer(inputNumber);

        int[] digits = analyzer.GetDigits();
        Console.WriteLine("Массив цифр: " + string.Join(", ", digits));

        if (analyzer.IsSymmetrical())
        {
            Console.WriteLine("Число является симметричным (палиндром).");
        }
        else if (analyzer.AllDigitsAreSame())
        {
            Console.WriteLine("Все цифры в числе одинаковые.");
        }
        else if (analyzer.IsIncreasing())
        {
            Console.WriteLine("Цифры числа расположены по возрастанию.");
        }
        else if (analyzer.IsDecreasing())
        {
            Console.WriteLine("Цифры числа расположены по убыванию.");
        }
        else
        {
            Console.WriteLine("Число не имеет специальных свойств.");
        }
    }
}

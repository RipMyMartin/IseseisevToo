using System;

class ArrayOrderChecker
{
    public static string CheckOrder(int[] numbers)
    {
        bool isAscending = true;
        bool isDescending = true;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                isAscending = false;
            }
            if (numbers[i] > numbers[i - 1])
            {
                isDescending = false;
            }
        }

        if (isAscending)
        {
            return "Массив упорядочен по возрастанию.";
        }
        else if (isDescending)
        {
            return "Массив упорядочен по убыванию.";
        }
        else
        {
            return "Массив неупорядочен.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Ввод 5 чисел
        Console.WriteLine("Введите 5 целых чисел:");
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        string result = ArrayOrderChecker.CheckOrder(numbers);
        Console.WriteLine(result);
    }
}

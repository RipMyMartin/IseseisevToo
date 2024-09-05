using System;

class ArrayMinMaxFinder
{
    public static (double min, double max) FindMinMax(double[] numbers)
    {
        double min = numbers[0];
        double max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return (min, max);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        double[] numbers = new double[10];

        // Генерация массива случайных действительных чисел
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.NextDouble() * 200 - 100; // от -100 до 100
        }

        Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));

        var (min, max) = ArrayMinMaxFinder.FindMinMax(numbers);
        Console.WriteLine($"Минимальное число: {min}");
        Console.WriteLine($"Максимальное число: {max}");
    }
}

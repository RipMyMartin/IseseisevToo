using System;

class ArrayRangeCounter
{
    public static int CountElementsInRange(double[] numbers, double lowerBound, double upperBound)
    {
        int count = 0;
        foreach (double num in numbers)
        {
            if (num >= lowerBound && num <= upperBound)
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int N = random.Next(10, 30); // случайная длина массива от 10 до 30
        double[] numbers = new double[N];

        // Заполняем массив случайными числами в диапазоне от -200 до +200
        for (int i = 0; i < N; i++)
        {
            numbers[i] = random.NextDouble() * 400 - 200; // от -200 до +200
        }

        Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));

        int countInRange = ArrayRangeCounter.CountElementsInRange(numbers, -100, 100);
        Console.WriteLine($"Количество элементов в диапазоне от -100 до +100: {countInRange}");
    }
}

using System;

class ArrayRangeExclusionCounter
{
    public static int CountElementsOutOfRange(double[] numbers, double lowerBound, double upperBound)
    {
        int count = 0;
        foreach (double num in numbers)
        {
            if (num < lowerBound || num > upperBound)
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

        // Заполнение массива случайными числами в диапазоне от -50 до +50
        for (int i = 0; i < N; i++)
        {
            numbers[i] = random.NextDouble() * 100 - 50; // от -50 до +50
        }

        Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));

        int countOutOfRange = ArrayRangeExclusionCounter.CountElementsOutOfRange(numbers, -10, 10);
        Console.WriteLine($"Количество элементов вне диапазона от -10 до +10: {countOutOfRange}");
    }
}

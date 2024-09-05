using System;

class ArrayAnalyzer
{
    public double[] Numbers { get; set; }

    public ArrayAnalyzer(double[] numbers)
    {
        Numbers = numbers;
    }

    public double FindDifference()
    {
        double max = Numbers[0];
        double min = Numbers[0];

        foreach (double num in Numbers)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }

        return max - min;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        double[] numbers = new double[10];

        // Заполнение массива случайными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.NextDouble() * 100; // случайные числа от 0 до 100
        }

        Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));

        ArrayAnalyzer analyzer = new ArrayAnalyzer(numbers);
        double difference = analyzer.FindDifference();

        Console.WriteLine($"Разность между максимальным и минимальным элементом: {difference:F2}");
    }
}

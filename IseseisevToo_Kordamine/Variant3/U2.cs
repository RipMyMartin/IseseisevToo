using System;

class ArrayCounter
{
    public int[] Numbers { get; set; }

    public ArrayCounter(int[] numbers)
    {
        Numbers = numbers;
    }

    public int CountElementsInRange(int lowerBound, int upperBound)
    {
        int count = 0;
        foreach (int num in Numbers)
        {
            if (num > lowerBound && num < upperBound)
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
        int K = random.Next(5, 20); // случайная длина массива от 5 до 20
        int[] numbers = new int[K];

        // Заполнение массива случайными числами от -200 до 200
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-200, 200);
        }

        Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));

        ArrayCounter counter = new ArrayCounter(numbers);
        int count = counter.CountElementsInRange(0, 125);

        Console.WriteLine($"Количество элементов, удовлетворяющих условию 0 < M[i] < 125: {count}");
    }
}

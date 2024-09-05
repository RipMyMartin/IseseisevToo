using System;
using System.Linq;

class ArrayProcessor
{
    public int[] Numbers { get; set; }

    public ArrayProcessor(int[] numbers)
    {
        Numbers = numbers;
    }

    public int[] GetEvenNumbers()
    {
        return Numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
    }

    public int[] GetOddNumbers()
    {
        return Numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[20];

        // Заполняем массив случайными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

        ArrayProcessor processor = new ArrayProcessor(numbers);

        int[] evenNumbers = processor.GetEvenNumbers();
        int[] oddNumbers = processor.GetOddNumbers();

        Console.WriteLine("Четные числа (отсортированные): " + string.Join(", ", evenNumbers));
        Console.WriteLine("Нечетные числа (отсортированные): " + string.Join(", ", oddNumbers));
    }
}

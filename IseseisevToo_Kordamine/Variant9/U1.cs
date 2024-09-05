using System;

class MatrixCalculator
{
    public static (int sum, long product) CalculateSumAndProduct(int[,] matrix)
    {
        int sum = 0;
        long product = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
                product *= matrix[i, j];
            }
        }

        return (sum, product);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[,] matrix = new int[10, 10];

        // Заполнение матрицы случайными числами от 1 до 10
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(1, 11);
            }
        }

        Console.WriteLine("Матрица 10x10:");
        MatrixCalculator.PrintMatrix(matrix);

        var (sum, product) = MatrixCalculator.CalculateSumAndProduct(matrix);
        Console.WriteLine($"Сумма элементов: {sum}");
        Console.WriteLine($"Произведение элементов: {product}");
    }
}

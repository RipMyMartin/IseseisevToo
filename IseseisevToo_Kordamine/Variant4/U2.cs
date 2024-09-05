using System;

class MatrixAnalyzer
{
    public int[,] Matrix { get; set; }

    public MatrixAnalyzer(int[,] matrix)
    {
        Matrix = matrix;
    }

    public (int positives, int negatives) CountPositivesAndNegatives()
    {
        int positives = 0;
        int negatives = 0;

        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                if (Matrix[i, j] > 0)
                {
                    positives++;
                }
                else if (Matrix[i, j] < 0)
                {
                    negatives++;
                }
            }
        }

        return (positives, negatives);
    }

    public void PrintZeroCoordinates()
    {
        Console.WriteLine("Координаты нулевых элементов:");
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                if (Matrix[i, j] == 0)
                {
                    Console.WriteLine($"Ноль на позиции: строка {i + 1}, столбец {j + 1}");
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[4, 4]
        {
            { 1, -2, 0, 4 },
            { -3, 5, 0, 0 },
            { 6, -7, 8, 9 },
            { 0, 0, -1, -10 }
        };

        MatrixAnalyzer analyzer = new MatrixAnalyzer(matrix);
        var (positives, negatives) = analyzer.CountPositivesAndNegatives();

        Console.WriteLine($"Положительных элементов: {positives}");
        Console.WriteLine($"Отрицательных элементов: {negatives}");

        analyzer.PrintZeroCoordinates();
    }
}

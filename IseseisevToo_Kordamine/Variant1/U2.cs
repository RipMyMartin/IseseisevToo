using System;

class MatrixAnalyzer
{
    public double[,] Matrix { get; set; }

    public MatrixAnalyzer(double[,] matrix)
    {
        Matrix = matrix;
    }

    public double[] RowSums()
    {
        double[] sums = new double[Matrix.GetLength(0)];
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                sums[i] += Matrix[i, j];
            }
        }
        return sums;
    }

    public double[] ColumnProducts()
    {
        double[] products = new double[Matrix.GetLength(1)];
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            products[j] = 1;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                products[j] *= Matrix[i, j];
            }
        }
        return products;
    }

    public double MaxDiagonalElement()
    {
        double max = Matrix[0, 0];
        for (int i = 1; i < Matrix.GetLength(0); i++)
        {
            if (Matrix[i, i] > max)
            {
                max = Matrix[i, i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = new double[10, 10];
        Random random = new Random();

        // Заполняем матрицу случайными числами
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = random.NextDouble() * 10;
            }
        }

        MatrixAnalyzer analyzer = new MatrixAnalyzer(matrix);

        // Суммы строк
        double[] rowSums = analyzer.RowSums();
        Console.WriteLine("Суммы строк:");
        for (int i = 0; i < rowSums.Length; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {rowSums[i]:F2}");
        }

        // Произведения столбцов
        double[] colProducts = analyzer.ColumnProducts();
        Console.WriteLine("\nПроизведения столбцов:");
        for (int j = 0; j < colProducts.Length; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {colProducts[j]:F2}");
        }

        // Максимальный элемент главной диагонали
        double maxDiagonal = analyzer.MaxDiagonalElement();
        Console.WriteLine($"\nМаксимальный элемент главной диагонали: {maxDiagonal:F2}");
    }
}

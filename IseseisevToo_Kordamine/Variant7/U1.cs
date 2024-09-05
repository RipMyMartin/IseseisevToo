using System;

class MatrixRowSwapper
{
    public static void SwapRows(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount - 1; i += 2)
        {
            for (int j = 0; j < colCount; j++)
            {
                // Меняем строки i и i+1
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i + 1, j];
                matrix[i + 1, j] = temp;
            }
        }
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
        int[,] matrix = new int[4, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("Исходная матрица:");
        MatrixRowSwapper.PrintMatrix(matrix);

        MatrixRowSwapper.SwapRows(matrix);

        Console.WriteLine("Матрица после перестановки строк:");
        MatrixRowSwapper.PrintMatrix(matrix);
    }
}

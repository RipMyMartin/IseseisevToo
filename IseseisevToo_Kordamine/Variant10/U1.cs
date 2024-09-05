using System;

class MatrixSorter
{
    public static void SortMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rowLength = matrix.GetLength(1);
            int[] row = new int[rowLength];

            for (int j = 0; j < rowLength; j++)
            {
                row[j] = matrix[i, j];
            }

            if (i % 2 == 0) // Четная строка, сортировка по убыванию
            {
                Array.Sort(row);
                Array.Reverse(row);
            }
            else // Нечетная строка, сортировка по возрастанию
            {
                Array.Sort(row);
            }

            for (int j = 0; j < rowLength; j++)
            {
                matrix[i, j] = row[j];
            }
        }
    }

    public static void PrintColumn(int[,] matrix, int columnIndex)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine(matrix[i, columnIndex]);
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
        Random random = new Random();
        int rows = 4;
        int cols = 5;
        int[,] matrix = new int[rows, cols];

        // Заполнение матрицы случайными числами от 1 до 100
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("Исходная матрица:");
        MatrixSorter.PrintMatrix(matrix);

        MatrixSorter.SortMatrix(matrix);

        Console.WriteLine("Отсортированная матрица:");
        MatrixSorter.PrintMatrix(matrix);

        Console.Write("Введите номер столбца для вывода (индекс от 0): ");
        int columnIndex = int.Parse(Console.ReadLine());

        Console.WriteLine($"Значения {columnIndex}-го столбца:");
        MatrixSorter.PrintColumn(matrix, columnIndex);
    }
}

using System;

class CinemaSeatBooking
{
    private static Random random = new Random();

    public static void GenerateCinemaHall(int[,] hall)
    {
        for (int i = 0; i < hall.GetLength(0); i++)
        {
            for (int j = 0; j < hall.GetLength(1); j++)
            {
                hall[i, j] = random.Next(0, 2); // Генерация 0 или 1
            }
        }
    }

    public static void PrintCinemaHall(int[,] hall)
    {
        Console.WriteLine("Схема зала (0 — свободно, 1 — занято):");
        for (int i = 0; i < hall.GetLength(0); i++)
        {
            for (int j = 0; j < hall.GetLength(1); j++)
            {
                Console.Write(hall[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static bool BookSeat(int[,] hall, int row, int seat)
    {
        if (hall[row, seat] == 0)
        {
            hall[row, seat] = 1;
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int rows = 5;
        int seatsPerRow = 5;
        int[,] cinemaHall = new int[rows, seatsPerRow];

        // Генерация схемы зала
        CinemaSeatBooking.GenerateCinemaHall(cinemaHall);
        CinemaSeatBooking.PrintCinemaHall(cinemaHall);

        while (true)
        {
            Console.Write("Введите ряд (1-5): ");
            int row = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Введите место (1-5): ");
            int seat = int.Parse(Console.ReadLine()) - 1;

            if (CinemaSeatBooking.BookSeat(cinemaHall, row, seat))
            {
                Console.WriteLine("Место успешно забронировано!");
            }
            else
            {
                Console.WriteLine("Это место уже занято, выберите другое.");
            }

            // Вывод обновленной схемы зала
            CinemaSeatBooking.PrintCinemaHall(cinemaHall);

            Console.WriteLine("Хотите забронировать еще одно место? (да/нет): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "да")
            {
                break;
            }
        }
    }
}

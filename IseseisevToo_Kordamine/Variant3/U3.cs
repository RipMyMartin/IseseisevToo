using System;
using System.Collections.Generic;

class JosephusProblem
{
    public static int FindLastPerson(int n, int m)
    {
        List<int> people = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            people.Add(i);
        }

        int currentIndex = 0;
        while (people.Count > 1)
        {
            currentIndex = (currentIndex + m - 1) % people.Count;
            people.RemoveAt(currentIndex);
        }

        return people[0]; // Последний оставшийся человек
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество людей: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите шаг m: ");
        int m = int.Parse(Console.ReadLine());

        int lastPerson = JosephusProblem.FindLastPerson(n, m);
        Console.WriteLine($"Номер последнего оставшегося в живых: {lastPerson}");
    }
}

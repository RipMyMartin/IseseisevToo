using System;
using System.Collections.Generic;
using System.Linq;

class SalaryManager
{
    public static void RemoveEmployee(ref List<string> names, ref List<int> salaries, string name)
    {
        int index = names.IndexOf(name);
        if (index != -1)
        {
            names.RemoveAt(index);
            salaries.RemoveAt(index);
        }
    }

    public static (int salary, string name) FindHighestSalary(List<string> names, List<int> salaries)
    {
        int maxSalary = salaries.Max();
        int index = salaries.IndexOf(maxSalary);
        return (maxSalary, names[index]);
    }

    public static void FindSameSalaries(List<string> names, List<int> salaries)
    {
        var salaryGroups = salaries
            .Select((salary, index) => new { salary, name = names[index] })
            .GroupBy(x => x.salary)
            .Where(g => g.Count() > 1);

        Console.WriteLine("Сотрудники с одинаковой зарплатой:");
        foreach (var group in salaryGroups)
        {
            Console.WriteLine($"Зарплата: {group.Key}");
            foreach (var item in group)
            {
                Console.WriteLine($"  {item.name}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "A", "B", "C", "D", "E" };
        List<int> salaries = new List<int> { 1200, 2500, 750, 395, 1200 };

        // Удаление сотрудника
        Console.Write("Введите имя сотрудника для удаления: ");
        string nameToRemove = Console.ReadLine();
        SalaryManager.RemoveEmployee(ref names, ref salaries, nameToRemove);

        Console.WriteLine("Обновленный список сотрудников и зарплат:");
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i]}: {salaries[i]}");
        }

        // Нахождение самой большой зарплаты
        var (highestSalary, highestSalaryName) = SalaryManager.FindHighestSalary(names, salaries);
        Console.WriteLine($"Самая большая зарплата: {highestSalary}, получает: {highestSalaryName}");

        // Нахождение сотрудников с одинаковой зарплатой
        SalaryManager.FindSameSalaries(names, salaries);
    }
}

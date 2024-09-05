using System;

class TaxCalculator
{
    // Ставка подоходного налога в процентах
    private const double TaxRate = 13.0;

    public static double CalculateIncomeTax(double salary)
    {
        return salary * TaxRate / 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите вашу зарплату: ");
        double salary = double.Parse(Console.ReadLine());

        double tax = TaxCalculator.CalculateIncomeTax(salary);
        Console.WriteLine($"Ваш подоходный налог составляет: {tax:F2}");
    }
}

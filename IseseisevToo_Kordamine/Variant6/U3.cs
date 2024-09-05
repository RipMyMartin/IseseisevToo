using System;
using System.Collections.Generic;
using System.Linq;

class Resident
{
    public string FullName { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public DateTime BirthDate { get; set; }

    public Resident(string fullName, string street, string house, DateTime birthDate)
    {
        FullName = fullName;
        Street = street;
        House = house;
        BirthDate = birthDate;
    }

    // Вычисление возраста
    public int GetAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
        {
            age--;
        }
        return age;
    }
}

class VoterListGenerator
{
    public static List<Resident> GetEligibleVoters(Resident[] residents, string street, string house)
    {
        return residents
            .Where(r => r.Street == street && r.House == house && r.GetAge() >= 18)
            .OrderBy(r => r.FullName)
            .ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Пример данных о жителях
        Resident[] residents = new Resident[]
        {
            new Resident("Иванов Иван Иванович", "Ленина", "10", new DateTime(1990, 5, 10)),
            new Resident("Петров Петр Петрович", "Ленина", "10", new DateTime(2005, 1, 1)),
            new Resident("Сидоров Сидор Сидорович", "Кирова", "20", new DateTime(1985, 3, 5)),
            new Resident("Антонов Антон Антонович", "Ленина", "10", new DateTime(1975, 7, 20)),
            new Resident("Ильина Ильина Ильинична", "Ленина", "10", new DateTime(1995, 12, 15)),
        };

        // Запрашиваем адрес
        Console.Write("Введите улицу: ");
        string street = Console.ReadLine();

        Console.Write("Введите дом: ");
        string house = Console.ReadLine();

        // Генерируем список избирателей
        List<Resident> voters = VoterListGenerator.GetEligibleVoters(residents, street, house);

        // Выводим результат
        if (voters.Count > 0)
        {
            Console.WriteLine("Список избирателей:");
            foreach (var voter in voters)
            {
                Console.WriteLine(voter.FullName);
            }
        }
        else
        {
            Console.WriteLine("Избирателей по данному адресу не найдено.");
        }
    }
}

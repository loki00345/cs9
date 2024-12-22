using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Journal
    {
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public int EmployeeCount { get; set; }

        public void InputData()
        {
            Console.Write("Введіть назву журналу: ");
            Name = Console.ReadLine();
            Console.Write("Введіть рік заснування: ");
            YearFounded = int.Parse(Console.ReadLine());
            Console.Write("Введіть опис журналу: ");
            Description = Console.ReadLine();
            Console.Write("Введіть контактний телефон: ");
            ContactPhone = Console.ReadLine();
            Console.Write("Введіть email: ");
            Email = Console.ReadLine();
            Console.Write("Введіть кількість працівників: ");
            EmployeeCount = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Рік заснування: {YearFounded}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Контактний телефон: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Кількість працівників: {EmployeeCount}");
        }

        public static Journal operator +(Journal journal, int employeesToAdd)
        {
            journal.EmployeeCount += employeesToAdd;
            return journal;
        }

        public static Journal operator -(Journal journal, int employeesToRemove)
        {
            journal.EmployeeCount -= employeesToRemove;
            return journal;
        }

        public static bool operator ==(Journal j1, Journal j2) => j1.EmployeeCount == j2.EmployeeCount;
        public static bool operator !=(Journal j1, Journal j2) => j1.EmployeeCount != j2.EmployeeCount;
        public static bool operator <(Journal j1, Journal j2) => j1.EmployeeCount < j2.EmployeeCount;
        public static bool operator >(Journal j1, Journal j2) => j1.EmployeeCount > j2.EmployeeCount;
        public static bool operator <=(Journal j1, Journal j2) => j1.EmployeeCount <= j2.EmployeeCount;
        public static bool operator >=(Journal j1, Journal j2) => j1.EmployeeCount >= j2.EmployeeCount;

        public override bool Equals(object obj) => obj is Journal journal && EmployeeCount == journal.EmployeeCount;
        public override int GetHashCode() => EmployeeCount.GetHashCode();
    }

    class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ProfileDescription { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public double Area { get; set; }

        public void InputData()
        {
            Console.Write("Введіть назву магазину: ");
            Name = Console.ReadLine();
            Console.Write("Введіть адресу магазину: ");
            Address = Console.ReadLine();
            Console.Write("Введіть опис профілю магазину: ");
            ProfileDescription = Console.ReadLine();
            Console.Write("Введіть контактний телефон: ");
            ContactPhone = Console.ReadLine();
            Console.Write("Введіть email: ");
            Email = Console.ReadLine();
            Console.Write("Введіть площу магазину: ");
            Area = double.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва магазину: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Опис профілю: {ProfileDescription}");
            Console.WriteLine($"Контактний телефон: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Площа магазину: {Area}");
        }

        public static Store operator +(Store store, double areaToAdd)
        {
            store.Area += areaToAdd;
            return store;
        }

        public static Store operator -(Store store, double areaToRemove)
        {
            store.Area -= areaToRemove;
            return store;
        }

        public static bool operator ==(Store s1, Store s2) => s1.Area == s2.Area;
        public static bool operator !=(Store s1, Store s2) => s1.Area != s2.Area;
        public static bool operator <(Store s1, Store s2) => s1.Area < s2.Area;
        public static bool operator >(Store s1, Store s2) => s1.Area > s2.Area;

        public override bool Equals(object obj) => obj is Store store && Area == store.Area;
        public override int GetHashCode() => Area.GetHashCode();
    }

    class Program
    {
        static void Main()
        {
            Journal journal1 = new Journal();
            journal1.InputData();
            journal1.DisplayData();
            journal1 += 5;
            journal1.DisplayData();
            Store store1 = new Store();
            store1.InputData();
            store1.DisplayData();
            store1 += 100.5;
            store1.DisplayData();
        }
    }
}

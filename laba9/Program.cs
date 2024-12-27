using System;
using static laba9.Class1;

namespace  xd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banknote banknote1 = new Banknote(10, 5);
                Banknote banknote2 = new Banknote(5, 10);

                int total1 = banknote1.CalculateTotalAmount();
                int total2 = banknote2.CalculateTotalAmount();

                Console.WriteLine($"Сумма {banknote1.Denomination} купюр: {total1}");
                Console.WriteLine($"Сумма {banknote2.Denomination} купюр: {total2}");

                int totalSum = total1 + total2;
                Console.WriteLine($"Общая сумма: {totalSum}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
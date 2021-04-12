using System;

namespace WorkLab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление счётчика для среднего арефметического
            int count = 0;
            double Total = 0;
            // Объявление переменны для ввода 
            double N;
            do
            {
                Console.Write("Введите число ");
                N = double.Parse(Console.ReadLine());
                Total += N;
                count++;
            } while (N >= 3);

            double result = Total / count;

            Console.WriteLine($"Среднее арифметическое введенных чисел:{result}\nКоличество введеных чисел:{count}");
            Console.ReadLine();
        }
    }
}

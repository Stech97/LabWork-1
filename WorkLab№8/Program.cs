using System;

namespace WorkLab_8
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());
            double sumX = 0;
            double sumY = 0;

            for (int i = 1; i <= 10; i++)
            {
               Calc(i, x, ref sumX);
               Calc(i, y, ref sumY); 
            }
            Console.WriteLine($"Результат работы\nSum int: {sumX}\nSum double: {sumY}");
            Console.ReadLine();
        }

        private static void Calc(int n, int x, ref double result)
        {
            result += n / Math.Pow(x, n);
        }

        private static void Calc(int n, double x, ref double result)
        {
            result += n / Math.Pow(x, n);
        }
    }
}

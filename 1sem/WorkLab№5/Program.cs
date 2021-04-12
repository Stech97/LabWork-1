using System;

namespace WorkLab_5
{
    class Program
    {
        public static void CalcMin(double x, double a, double b, ref int count)
        {
            double y = 0;
            if (x > 2.2)
                y = Math.Sqrt(x + Math.Pow(Math.E, x));
            else
            {
                if (x < 0.2)
                    y = a * Math.Pow(x, 2.0) + b;
                else
                    y = Math.PI * x;
            }
            if (y > 0)
                count++;               
        }

        static void Main(string[] args)
        {
            //Ввод значений для нахождения минимального
            Console.Write("Значение a: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Значение b: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Значение c: ");
            double x3 = double.Parse(Console.ReadLine());
            double a = 0.12;
            double b = -4.4;

            int count = 0;
            CalcMin(x1, a, b, ref count);
            CalcMin(x2, a, b, ref count);
            CalcMin(x3, a, b, ref count);
            
            if (count > 0)
                Console.Write($"Из значений функции в точках: {x1} {x2} и {x3} количество больше 0: {count}");
            else
                Console.Write($"Из значений функции в точках: {x1} {x2} и {x3} количество больше 0 нет");

            Console.ReadLine();
        }
    }
}

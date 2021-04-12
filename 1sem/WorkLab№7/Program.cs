using System;

namespace WorkLab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива ");
            //количество элементов в массиве mass
            int N = int.Parse(Console.ReadLine());
            //объявление с выделение памяти под N элементов
            double[] mass = new double[N];
            
            //Заполнение массива данными
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива ");
                mass[i] = double.Parse(Console.ReadLine());
            }

            //проверка первого условия
            //Количество элементов в интервале [0; 5] 
            int count = 0;
            //Подсчёт элементов поподающих в промежуток
            foreach (int item in mass)
                if (item >= 0 && item <= 5)
                    count++;

            if (count > 0)
                Console.WriteLine($"Количество элементов, попадающих в интервал [0; 5] {count}");
            else
                Console.WriteLine("Нет элементов, попадающих в интервал [0; 5]");

            //проверка второго условия
            //Максимальное значение
            double max = mass[0];
            //Место максимального значеиния
            int ElMax = 0;
            //Поиск максимального занчения 
            for (int i = 0; i < N; i++) 
                if (max < mass[i])
                {
                    max = mass[i];
                    ElMax = i;
                }
            Console.WriteLine();
            Console.Write($"Исходный массив:");
            foreach (double item in mass)
                Console.Write($"{item} ");

            mass[ElMax] = 1000;
            Console.WriteLine();
            Console.Write($"Измененный массив:");
            foreach (double item in mass)
                Console.Write($"{item} ");

            //проверка третьего условия
            // временная переменная для перестановки в конец массива  максимального элемента
            double temp = mass[N-1];
            mass[N-1] = max;
            mass[ElMax] = temp;
            Console.WriteLine();
            Console.Write($"Максимальный элемент в конце массива:");
            foreach (double item in mass)
                Console.Write($"{item} ");

            Console.ReadLine();

        }
    }
}

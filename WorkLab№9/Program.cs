using System;
using System.Collections.Generic;

namespace WorkLab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[100];
            int[] mas2 = new int[100];
            int[] mas3 = new int[100];
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            Random rnd = new Random();

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 100; i++)
            {
                mas1[i] = mas2[i] = mas3[i] = rnd.Next(0, 100);
                Console.Write($"{mas1[i]} ");
            }


            Console.WriteLine("\nСортировка пузырьком");
            BubbleSort(ref mas1, ref count1);

            Console.WriteLine("Сортировка выбором");
            SelectionSort(ref mas2, ref count2);

            Console.WriteLine("Быстрая сортировка");
            QuickSort(ref mas3, 0, mas3.Length-1, ref count3);

            Console.WriteLine("Дихотомический поиск элемента в массиве");
            IndexOf(ref mas3, 65, 0, mas3.Length - 1, ref count4);

            Console.WriteLine("Отсортированный массив");

            for (int i = 0; i < 100; i++)
                Console.Write($"{mas1[i]} ");

            Console.WriteLine($"\nСортировка пузырьком выполнена за {count1} шагов");
            Console.WriteLine($"Сортировка выбором выполнена за {count2} шагов");
            Console.WriteLine($"Быстрая сортировка выполнена за {count3} шагов");
            Console.WriteLine($"Дихотомический поиск элемента в массиве выполнен за {count4} шагов");

            Console.ReadLine();
        }

        static void BubbleSort(ref int[] Array, ref int count)
        {
            for (int i = 0; i < Array.Length - 1; i++)
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        int t = Array[i];
                        Array[i] = Array[j];
                        Array[j] = t;
                    }
                    count++;
                }
        }

        static void SelectionSort(ref int[] Array, ref int count)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                        min = j;
                    count++;                    
                }
                if (min != i)
                {
                    int t = Array[i];
                    Array[i] = Array[min];
                    Array[min] = t;
                }
            }
        }

        static void QuickSort(ref int[] Array, int Left, int Right, ref int count)
        {
            int i = Left;
            int j = Right;
            int x = Array[(Left + Right) / 2];
            do
            {
                while (Array[i] < x)
                    ++i;
                while (Array[j] > x) 
                    --j;
                if (i <= j)
                {
                    int t = Array[i];
                    Array[i] = Array[j];
                    Array[j] = t;
                    i++;
                    j--;
                }
                count++;
            } while (i <= j);
            if (Left < j)
                QuickSort(ref Array, Left, j, ref count);
            if (i < Right)
                QuickSort(ref Array, i, Right, ref count);
        }

        static int IndexOf(ref int[] Array, int Value, int Left, int Right, ref int count)
        {
            count++;
            int x = (Left + Right) / 2;
            if (Array[x] == Value)
                return x;
            if ((x == Left) || (x == Right))
                return -1;
            if (Array[x] < Value)
                return IndexOf(ref Array, Value, x, Right, ref count);
            else
                return IndexOf(ref Array, Value, Left, x, ref count);
        }
    }
}

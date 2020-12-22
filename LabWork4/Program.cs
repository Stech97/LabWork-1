using System;

namespace WorkLab_4
{

    struct Student
    {
        public string LastName;
        public string FirstName;
        public int result1;
        public int result2;
        public double totalResult;

        public void Display()
        {
            Console.WriteLine($"Данные студента\nИмя: {FirstName} Фамилия: {LastName}  Средняя оценка:{totalResult}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Количество студентов (элементов в массиве структур)
            Console.Write("Количество студентов: ");
            int N = int.Parse(Console.ReadLine());
            if (N <= 20)
            {
                // объявляем массив Student структур (из n элементов)
                Student[] students = new Student[N];
                // Заполняем данные об N студентах и считаем среднее
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Студент {i + 1}");
                    Console.Write("Фамилия: ");
                    students[i].LastName = Console.ReadLine();
                    Console.Write("Имя: ");
                    students[i].FirstName = Console.ReadLine();
                    Console.Write("Первая оценка: ");
                    students[i].result1 = int.Parse(Console.ReadLine());
                    Console.Write("Вторая оценка: ");
                    students[i].result2 = int.Parse(Console.ReadLine());
                    students[i].totalResult = (students[i].result1 + students[i].result2) / 2.0;
                }

                Console.WriteLine();
                Console.WriteLine("Студенты на «отлично»");
                // Студенты на «отлично»
                for (int i = 0; i < N; i++)
                    if (students[i].result1 == 5 && students[i].result2 == 5)
                        students[i].Display();


                Console.WriteLine();
                Console.WriteLine("Студенты с одной оценкой 4");
                // Студенты с одной оценкой 4
                for (int i = 0; i < N; i++)
                    if (students[i].result1 == 4 || students[i].result2 == 4)
                        students[i].Display();

                // Сортировка студентов по среднему баллу
                Student temp;
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (students[i].totalResult > students[j].totalResult)
                        {
                            temp = students[i];
                            students[i] = students[j];
                            students[j] = temp;
                        }
                    }
                }

                // Студенты по рейтингу
                Console.WriteLine();
                Console.WriteLine("Рейтинг студентов");
                for (int i = 0; i < N; i++)
                    students[i].Display();
            }
            else
                Console.WriteLine("Студентов больше 20");
            Console.ReadLine();
        }
    }
}

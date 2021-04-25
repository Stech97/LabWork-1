using System;
using System.Collections.Generic;


namespace WorkLab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var TraumatologyPatient1 = new TraumatologyPatient("Носов Николай Петрович", 34, "мужской", 2, 10, "-", false, "средння", false);
            var TherapyPatient1 = new TherapyPatient("Кротов Михаил Николаевич", 25, "мужской", 10, 2, "ОРВИ", "кашель", false, false);

            List<PersonClinic> vs = new List<PersonClinic>() { TraumatologyPatient1, TherapyPatient1 };

            foreach (var item in vs)
            {
                Console.WriteLine(item.Info());
            }

            Console.ReadLine();
        }
    }
}

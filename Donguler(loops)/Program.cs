using System;

namespace Donguler_loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "Programlamaya Başlangıç";
            string kurs3 = "JAVA Programlama";

            string[] kurslar = new string[] { "Yazılım Geliştirici Kursu", "Programlamaya Başlangıç", "JAVA Programlama","python","c#","c++" };
            
            
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("FOR BİTTİ");


            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs);


            }









        }
    }
}

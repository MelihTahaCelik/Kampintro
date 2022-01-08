using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Melih";
            int yas = 20;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi="C#";
            kurs1.Egitmen = "Engin";
            kurs1.izlenme = 50;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "JAVA  ";
            kurs2.Egitmen = "Mehmet";
            kurs2.izlenme = 59;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "Ali";
            kurs3.izlenme = 90;


            Kurs kurs4 = new Kurs();

            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "MURAT";
            kurs4.izlenme=  98;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };


            foreach (var kurs in kurslar)   
            {
                Console.WriteLine(kurs.KursAdi+":"+ kurs.Egitmen);
            }





        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int izlenme { get; set; }
      
        
    
    
    
    
    
    
    }







}

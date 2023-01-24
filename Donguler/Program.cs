using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
            String kurs2 = "Programlamaya baslangıc ıcın temel kurs";
            String kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);*/


            //array- dizi
            string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı", 
                "Programlamaya baslangıc ıcın temel kurs",
                "Java", "Phytob", "c#"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*********************For bitti!******************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}

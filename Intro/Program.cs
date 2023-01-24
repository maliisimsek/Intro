using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenliği
            //do not repeat yourself - Kendini tekrarlama
            //Değer tutucu - alias
            string kategoriEtiketi = "Kategori1";
            int ogrenciSayisi = 10;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 17.35;
            double dolarBugun = 17.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artıs Butonu");
            }
            else
            {
                Console.WriteLine("Degisiklik Yok Butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}

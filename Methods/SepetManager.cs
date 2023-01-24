using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi );

        }

        //Yanlış bir metot yapma şeklidir diğer yöntem daha doğrudur.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }

    }
}

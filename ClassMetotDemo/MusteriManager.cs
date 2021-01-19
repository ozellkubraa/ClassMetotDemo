using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi!  "  + musteri.Adi);
        }


        public void Listele(Musteri[] musteri)
        {
            foreach (var Musteri in musteri)
            {
                Console.WriteLine(Musteri);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +  "   Adlı müşteri silindi...!!!" );
        }
    }
}

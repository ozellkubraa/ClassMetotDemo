using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "Özel";
            musteri1.DogumYeri = "Ankara";
            musteri1.DogumYili = 1995;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Aslı";
            musteri2.SoyAdi = "Çoban";
            musteri2.DogumYeri = "Mardin";
            musteri2.DogumYili = 1990;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Selin";
            musteri3.SoyAdi = "Kelip";
            musteri3.DogumYeri = "İstanbul";
            musteri3.DogumYili = 1998;

            Musteri[] musteriler = new Musteri[] { musteri1 , musteri2 ,musteri3};

            foreach (var musteri in musteriler) //müşterileri listeledik 
            {
                Console.WriteLine("Müşteri Numarası : " + musteri.Id);
                Console.WriteLine("Adı : " + musteri.Adi);
                Console.WriteLine("Soyadı : " + musteri.SoyAdi);
                Console.WriteLine("Dogum Yeri : " + musteri.DogumYeri);
                Console.WriteLine("Dogum Yılı : " + musteri.DogumYili);
                Console.WriteLine("_____________________________");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); 
            musteriManager.Sil(musteri2);
           






        }

    }
}

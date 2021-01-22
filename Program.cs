using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi ="Nalan" ;
            musteri1.MusteriSoyadi = "Aksoy";
            musteri1.Id =1225916316;
            musteri1.Telefon = 05391551612;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Nasip";
            musteri2.Id = 1225159482;
            musteri2.Telefon = 05315187782;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Samet";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.Id = 1225915554;
            musteri3.Telefon = 05252242448;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Listeler(musteri1);

        }
        
    }


}

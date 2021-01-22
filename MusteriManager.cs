using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri sisteme eklendi"+ ": " + musteri.MusteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri sistemden silindi"+ ": " + musteri.MusteriAdi);
        }
        public void Listeler(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri:" + musteri.MusteriAdi + " " + musteri.MusteriSoyadi );
           
        }

    }
}

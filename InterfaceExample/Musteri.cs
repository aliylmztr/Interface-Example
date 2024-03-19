using System;

namespace InterfaceExample
{
    public class Musteri : IMusteri, IPersonel
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri getirildi.");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
       
        public void sil()
        {
            Console.WriteLine("Müşteri silindi.");
        }

        public void personelEkle()
        {
            Console.WriteLine("Personel eklendi.");
        }

    }
}

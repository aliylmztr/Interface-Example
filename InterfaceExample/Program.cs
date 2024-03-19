using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMusteri musteri = new Musteri();
            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.sil();

            Console.ReadLine();
                        
        }
    }
}

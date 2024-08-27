using Inheritance;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesnesi oluşturma ve değer atama
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Mehmet",
            Soyad = "Onat",
            OgrenciNumarasi = "123456"
        };

        // Öğrenci bilgilerini yazdırma
        ogrenci.OgrenciBilgileriniYazdir();

        // Öğretmen nesnesi oluşturma ve değer atama
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Ali",
            Soyad = "Yıldırım",
            Maas = 8500
        };

        // Öğretmen bilgilerini yazdırma
        ogretmen.OgretmenBilgileriniYazdir();
    }
}
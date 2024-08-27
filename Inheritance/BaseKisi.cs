using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    class Ogrenci : BaseKisi
    {
        public string OgrenciNumarasi { get; set; }

        public void OgrenciBilgileriniYazdir()
        {
            AdSoyadYazdir(); // Base sınıfındaki metodu çağırıyoruz
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        }
    }

    class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgileriniYazdir()
        {
            AdSoyadYazdir(); // Base sınıfındaki metodu çağırıyoruz
            var cultureInfo = new CultureInfo("tr-TR");
            var numberFormatInfo = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
            numberFormatInfo.CurrencySymbol = "TL";  // TL simgesini kullanıyoruz
            Console.WriteLine($"Maaş: {Maas.ToString("C", numberFormatInfo)}");
        }
    }
}

using System;

namespace Sınıf_Nedir__Instance__Field__Property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirleyiciler

            // Public
            // Private
            // Internal // Kendi bulunduğu proje içinde erişilebilen.
            // Protected // Sadece kendi sınıfında kullanılabilir.
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Onur";
            calisan1.SoyAd = "Çöpoğlu";
            calisan1.No = 1324;
            calisan1.Departman = "Yazılım Departmanı";

            calisan1.CalisanBilgileri();

            Console.WriteLine("- - - - - - - - - - - - ");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ömer";
            calisan2.SoyAd = "Kaya";
            calisan2.No = 1323;
            calisan2.Departman = "İnsan Kaynakları";
            
            calisan2.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı :{0}" , this.Ad);
            Console.WriteLine("Çalışan Soy adı :{0}" , this.SoyAd);
            Console.WriteLine("Çalışan Numarası :{0}" , this.No);
            Console.WriteLine("Çalışan Departmanı :{0}" , this.Departman);
            //Console.WriteLine("Çalışan adı :"+Ad);
            //Console.WriteLine("Çalışan Soy adı :"+SoyAd);
            //Console.WriteLine("Çalışan Numarası :"+No);
            //Console.WriteLine("Çalışan Departmanı :"+Departman);

        }
    }
}

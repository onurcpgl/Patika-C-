using System;

namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
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
            Console.WriteLine("Calısan  ** 1 **");
            Calisan calisan1 = new Calisan("Onur","Çöpoğlu",1324,"Yazılım Departmanı");
            

            calisan1.CalisanBilgileri();

            Console.WriteLine("- - - - - - - - - - - - ");

            Console.WriteLine("Calısan  ** 2 **");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ömer";
            calisan2.SoyAd = "Kaya";
            calisan2.No = 1323;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();

            Console.WriteLine("- - - - - - - - - - - - ");

            Console.WriteLine("Calısan  ** 3 **");

            
            Calisan calisan3 = new Calisan("Emirhan", "Çöpoğlu");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calisan()
        {

        }
        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = no;
            this.Departman = departman;

        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı :{0}", this.Ad);
            Console.WriteLine("Çalışan Soy adı :{0}", this.SoyAd);
            Console.WriteLine("Çalışan Numarası :{0}", this.No);
            Console.WriteLine("Çalışan Departmanı :{0}", this.Departman);
            //Console.WriteLine("Çalışan adı :"+Ad);
            //Console.WriteLine("Çalışan Soy adı :"+SoyAd);
            //Console.WriteLine("Çalışan Numarası :"+No);
            //Console.WriteLine("Çalışan Departmanı :"+Departman);

        }
    }
}

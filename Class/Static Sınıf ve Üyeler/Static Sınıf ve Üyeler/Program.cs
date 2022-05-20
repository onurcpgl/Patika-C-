using System;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayısı : {0}",Calisan.CalisanSayisi); 
            Calisan calisan = new Calisan("Onur","Çöpoğlu","Yazılım Departmanı");
            Console.WriteLine("Calisan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Emirhan", "Çöpoğlu", "Yazılım Departmanı");
            Console.WriteLine("Calisan Sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Topllama işlemi sonucu");
            Console.WriteLine(Islemler.Topla(100,200));

            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Çıkar(400,300)); 


        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi
        {
            get { return calisanSayisi; }
        }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        
        public Calisan(string isim,string soyisim,string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
          

    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}

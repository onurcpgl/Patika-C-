using System;

namespace Encapsulation_ve_Property_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Onur";
            ogrenci.Soyisim = "Çöpoğlu";
            ogrenci.OgrenciNo = 12053233;
            ogrenci.Sınıf = 2;
            
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",12312,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            Console.ReadLine();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim
        {
            get { return isim; }
            set { isim=value; }
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sınıf 
        { 
            get { return sınıf; }
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sınıf = 1;
                }
                else
                {
                    sınıf = value;
                }
                
            
            } 
        }

        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sınıf)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }
        public Ogrenci(){}
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("---- ÖĞRENCİ BİLGİLERİ -----");
            Console.WriteLine("Öğrenci adı   :{0}",this.Isim);
            Console.WriteLine("Öğrenci soyadı   :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci öğrenciNo   :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıf   :{0}",this.Sınıf);
        }
        public void SinifAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }
        public void SinifDusur()
        {
            
            this.Sınıf = this.Sınıf -1;
        }
    }
}

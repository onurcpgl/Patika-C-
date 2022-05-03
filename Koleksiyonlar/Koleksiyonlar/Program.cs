using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar
            //List<T> class
            //System.Collections.Generic;
            //T-> Object türündedir.

            List<int> sayiListesi = new List<int>();
            
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine("Renk listesinin eleman sayısı: "+renkListesi.Count);
            Console.WriteLine("Sayı listesinin eleman sayısı: " + sayiListesi.Count);

            foreach (object item in sayiListesi)
                Console.Write(item+"-");

            Console.WriteLine();

            foreach (object item in renkListesi)
                Console.Write(item + "-");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //Bir diğer yazdırma türü

            renkListesi.ForEach(renk => Console.Write(renk+"-"));


            //Listeden elemen çıkarma

            sayiListesi.Remove(4); //4'ü çıkar.
            renkListesi.Remove("Yeşil");


            sayiListesi.RemoveAt(0);//0.İndeksi çıkar dedik.
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); 
            renkListesi.ForEach(renk => Console.Write(renk + "-"));
            Console.WriteLine();
            //Liste içerisinde arama.
            
            if (sayiListesi.Contains(10))
                Console.WriteLine("Sayi listesi içinde {0} sayısı bulunur",10);
            else
                Console.WriteLine("Sayi listesi içinde {0} sayısı bulunamadı", 10);

            //Eleman ile index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            //Diziyi listeye çevirme

            string[] hayvan = {"Kedi","Köpek","Kuş","Maymun","Yılan"};
            //bir diziyi bu şekilde listeye atabiliriz.
            List<string> hayvanListesi = new List<string>(hayvan);


            //Liste temizleme
            hayvanListesi.Clear();

            //Liste içerisinde class tutmak.
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
           
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.İsim = "Onur";
            kullanıcı1.Soyisim = "Çöpoğlu";
            kullanıcı1.Yas = 22;
            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.İsim = "Elon";
            kullanıcı2.Soyisim = "Musk";
            kullanıcı2.Yas = 55;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                İsim = "Deniz",
                Soyisim = "Arda",
                Yas = 22

            });

            foreach (Kullanıcılar item in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı: "+item.İsim);
                Console.WriteLine("Kullanıcı soyadı: " + item.Soyisim);
                Console.WriteLine("Kullanıcı yasi: " + item.Yas);
            }

            yeniListe.Clear();

            Console.ReadLine();
        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        //Kapsülleme yaptık.
        public string İsim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }


    }
}

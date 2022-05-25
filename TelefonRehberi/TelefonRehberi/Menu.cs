using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Menu
    {
        public static void menuSayfa(List<Kisi> kisiListesi)
        {
            int secim = 0;
            Console.Clear();
            do
            {

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçinizi :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Ekleme");
                Console.WriteLine("(2) Varolan Numara Silme");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(6) Çıkış yap !!");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1: Islemler.noEkle(kisiListesi); break;
                    case 2: Islemler.noSil(kisiListesi); break;
                    case 3: Islemler.noGüncelle(kisiListesi); break;
                    case 4: Islemler.noListele(kisiListesi); break;
                    case 5: Islemler.noArama(kisiListesi); break;
                }
            } while (secim != 6);

        }
    }
}

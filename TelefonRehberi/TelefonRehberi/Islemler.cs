using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Islemler
    {
        public static void noEkle(List<Kisi> list)
        {
            Console.Clear();
            Console.WriteLine("Lütfen isim giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            int telno = int.Parse(Console.ReadLine());

            Kisi yeni = new Kisi();
            yeni.Isim = ad;
            yeni.SoyIsim = soyad;
            yeni.TelNo = telno;
            list.Add(yeni);
            Console.Clear();
            Console.WriteLine("Kayıt Başarıyla eklendi devam etmek için herhangi bir tuşa basınız.. !!!!!!!!!");
            Console.ReadLine();


        }
        public static void noSil(List<Kisi> list)
        {
        yeniden:
            Console.Clear();

            Console.Write("Lütfen silmek istediğiniz kişinin ismini giriniz:");
            string silAd = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Isim == silAd)
                {
                    Console.WriteLine("Aranan kişi bulundu silinsin mi ?(y/n)");
                    char secim = Convert.ToChar(Console.ReadLine());
                    if (secim == 'y')
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("Silme işlemi başarılı ");
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.... !!!!");
                        Console.ReadLine();
                    }
                    else if (secim == 'n')
                    {
                        count = count + 1;
                        Console.Clear();
                        break;
                    }
                    count = count + 1;
                    Console.Clear();

                }

            }
            if (count == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için (1)");
                Console.WriteLine("Yeniden denemek için (2)");
                int secilen = int.Parse(Console.ReadLine());
                switch (secilen)
                {

                    case 2: goto yeniden; break;
                }
            }

        }
        public static void noGüncelle(List<Kisi> list)
        {
        yeniden:
            Console.Clear();

            Console.Write("Lütfen güncellemek istediğiniz kişinin ismini giriniz:");
            string silAd = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Isim == silAd)
                {
                    Console.WriteLine("Aranan kişi bulundu güncellensin mi ?(y/n)");
                    char secim = Convert.ToChar(Console.ReadLine());
                    if (secim == 'y')
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("Yeni isim:");
                        string adi = Console.ReadLine();
                        Console.WriteLine("Yeni soyisim");
                        string soyisimm = Console.ReadLine();
                        Console.WriteLine("Yeni numara");
                        int yenino = int.Parse(Console.ReadLine());
                        Kisi yeniKisi = new Kisi { Isim = adi, SoyIsim = soyisimm, TelNo = yenino };
                        list.Add(yeniKisi);
                        Console.WriteLine("Güncelleme işlemi başarılı ");
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.... !!!!");

                        Console.ReadLine();
                    }
                    else if (secim == 'n')
                    {
                        count = count + 1;
                        Console.Clear();
                        break;
                    }
                    count = count + 1;
                    Console.Clear();

                }

            }
            if (count == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için (1)");
                Console.WriteLine("Yeniden denemek için (2)");
                int secilen = int.Parse(Console.ReadLine());
                switch (secilen)
                {

                    case 2: goto yeniden; break;
                }
            }

        }
        public static void noListele(List<Kisi> kisi)
        {
            Console.Clear();
            Console.WriteLine("************** Kayıtlı kişiler **************");
            for (int i = 0; i < kisi.Count; i++)
            {
                Console.WriteLine("İsim :" + kisi[i].Isim);
                Console.WriteLine("Soyisim :" + kisi[i].SoyIsim);
                Console.WriteLine("Telefon no :" + kisi[i].TelNo);
                Console.WriteLine("------ ----- ------ ------- ------- --------");
            }
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız ... !!!!!!!");
            Console.ReadLine();
            Console.Clear();

        }
        public static void noArama(List<Kisi> kisi)
        {
            Console.Clear();
            Console.WriteLine("Aramak istediğiniz tipi seciniz.");
            Console.WriteLine("*******************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için (2)");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                gel:
                Console.WriteLine("Aramak istediğiniz isim veya soyisim giriniz.");
                string aranan = Console.ReadLine();

                int count = 0;
                for (int i = 0; i < kisi.Count; i++)
                {
                    if (aranan == kisi[i].Isim || aranan == kisi[i].SoyIsim)
                    {
                        Console.WriteLine("Aranan kişi bulundu");
                        Console.WriteLine("İsim :" + kisi[i].Isim);
                        Console.WriteLine("Soyisim :" + kisi[i].SoyIsim);
                        Console.WriteLine("Telefon no :" + kisi[i].TelNo);
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basınız ....");
                        count++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if(count == 0)
                    {
                        Console.WriteLine("Aranan kişi bulunamadı \t Tekrar denemek için 1  \t Çıkmak için 2 ");
                        int secilen = int.Parse(Console.ReadLine());
                        if (secilen == 1)
                        {
                            goto gel;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
            gell:
                Console.WriteLine("Aranan kişinin numarasını giriniz...");
                int arananNo = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < kisi.Count; i++)
                {
                    if (arananNo == kisi[i].TelNo)
                    {
                        Console.WriteLine("Aranan kişi bulundu");
                        Console.WriteLine("İsim :" + kisi[i].Isim);
                        Console.WriteLine("Soyisim :" + kisi[i].SoyIsim);
                        Console.WriteLine("Telefon no :" + kisi[i].TelNo);
                        count++;
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if(count == 0)
                    {
                        Console.WriteLine("Aranan kişi bulunamadı \t Tekrar denemek için 1  \t Çıkmak için 2 ");
                        int secilen = int.Parse(Console.ReadLine());
                        if (secilen == 1)
                        {
                            goto gell;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}

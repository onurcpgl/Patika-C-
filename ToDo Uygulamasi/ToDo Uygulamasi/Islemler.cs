using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Islemler
    {

        public enum EnumBoyut
        {
            XS = 1,
            S,
            M,
            L,
            XL,
        }
        public static void kartEkle(List<ToDo> list)
        {
            Console.Clear();
            Console.Write("Başlık :");
            string bas = Console.ReadLine();
            Console.Write("İçerik :");
            string icerik = Console.ReadLine();
            Console.Write("Atanan Kişi :");
            string kisi = Console.ReadLine();
        gel:
            Console.Write("Boyut XS(1),S(2),M(3),L(4),XL(5) :");
            int buyukluk = int.Parse(Console.ReadLine());
            string kartboy;
            if (buyukluk == (int)EnumBoyut.XS)
                kartboy = "XS";
            else if (buyukluk == (int)EnumBoyut.S)
                kartboy= "S";
            else if (buyukluk == (int)EnumBoyut.M)
                kartboy = "M";
            else if (buyukluk == (int)EnumBoyut.L)
                kartboy = "L";
            else if (buyukluk == (int)EnumBoyut.XL)
                kartboy = "XL";
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                goto gel;
            }
            don:
            Console.Write("Line Seçiniz (TODO:1, IN PROGRESS:2, DONE:3)   :");
            int lineSecim= int.Parse(Console.ReadLine());
            string line;
            if (lineSecim == 1)
                line= "TODO";
            else if (lineSecim == 2)
                line = "IN PROGRESS";
            else if (lineSecim == 3)
                line = "DONE";
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                goto don;
            }
            ToDo yeni = new ToDo();
            yeni.baslık = bas;
            yeni.büyüklük = kartboy;
            yeni.icerik = icerik;
            yeni.kisi = kisi;
            yeni.lineSecim = line;
            list.Add(yeni);
            
        }
        public static void kartListele(List<ToDo> list)
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*************************");
            foreach (var item in list)
            {
                if (item.lineSecim == "TODO")
                {
                    Console.WriteLine("Başlık       :" + item.baslık);
                    Console.WriteLine("İçerik       :" + item.icerik);
                    Console.WriteLine("Atanan Kişi  :" + item.kisi);
                    Console.WriteLine("Büyüklük     :" + item.büyüklük);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*************************");
            foreach (var item in list)
            {


                if (item.lineSecim == "IN PROGRESS")
                {

                    Console.WriteLine("Başlık       :" + item.baslık);
                    Console.WriteLine("İçerik       :" + item.icerik);
                    Console.WriteLine("Atanan Kişi  :" + item.kisi);
                    Console.WriteLine("Büyüklük     :" + item.büyüklük);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("DONE Line");
            Console.WriteLine("*************************");
            foreach (var item in list)
            {
                if (item.lineSecim == "DONE")
                {

                    Console.WriteLine("Başlık       :" + item.baslık);
                    Console.WriteLine("İçerik       :" + item.icerik);
                    Console.WriteLine("Atanan Kişi  :" + item.kisi);
                    Console.WriteLine("Büyüklük     :" + item.büyüklük);
                    Console.WriteLine("-");
                }

            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }
        public static void kartsil(List<ToDo> list)
        {
            devam:
            Console.WriteLine("Lütfen silmek istediğiniz kart başlığını yazınız:");
            string silinecekBaslik = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].baslık == silinecekBaslik.ToLower())
                {
                    Console.WriteLine("Kayıt bulundu siliniyor...");
                    list.RemoveAt(i);
                    count++;
                    Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            if (count==0)
            {
                Console.Clear();
                Console.WriteLine(" Kayıt bulunmadı !!! ");
                Console.WriteLine(" (1) Tekrar dene .");
                Console.WriteLine(" (2) Çıkış .");
                int secilen = int.Parse(Console.ReadLine());
                switch (secilen)
                {
                    case 1: goto devam;
                    case 2: break;
                }
            }
        }
        public static void kartTaşı(List<ToDo> list)
        {
            Console.Clear();
            aa:
            Console.Write(" Değiştirmek istediğiniz başlığı giriniz :");
            string degis = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].baslık == degis)
                {
                    Console.WriteLine("Almak istediğiniz bölümü seciniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int line = int.Parse(Console.ReadLine());
                    if (line == 1)
                    {
                        list[i].lineSecim = "TODO";
                        Console.WriteLine("İşlem Tamamlandı...");
                    }
                    else if (line == 2)
                    {
                        list[i].lineSecim = "IN PROGRESS";
                        Console.WriteLine("İşlem Tamamlandı...");
                    }
                    else
                    {
                        list[i].lineSecim = "DONE";
                        Console.WriteLine("İşlem Tamamlandı...");
                    }
                    count++;
                }
            }
            if (count == 0)
            {
                Console.Clear();
                Console.WriteLine("Ardadığınız başlık bulunamadı ");
                Console.WriteLine("Tekrar denemek için (1)");
                Console.WriteLine("Çıkış yapmak için (2)");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: goto aa; break;
                    case 2: break;
                }
            }

        }
    }
}

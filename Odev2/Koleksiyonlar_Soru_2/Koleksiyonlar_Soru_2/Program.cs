using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {

        /*
         
         Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını
        alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
         
         */
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList büyük = new ArrayList();
            ArrayList kücük = new ArrayList();


            for (int i = 0; i <20; i++)
            {
                Console.Write((i+1)+". sayi :");
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }

            sayilar.Sort();
            kücük.Add(sayilar[0]);
            kücük.Add(sayilar[1]);
            kücük.Add(sayilar[2]);
            sayilar.Reverse();

            for (int i = 0; i < 3; i++)
            {
                büyük.Add(sayilar[i]);
            }
            int toplamb = 0;
            int toplamk = 0;
            for (int i = 0; i < 3; i++)
            {
                toplamb +=Convert.ToInt32(büyük[i]);
                toplamk +=Convert.ToInt32(kücük[i]);
            }

            Console.WriteLine("Büyük sayılar ortalaması :"+toplamb/büyük.Count);
            Console.WriteLine("Kücük sayılar ortalaması :"+toplamk/kücük.Count);
            int cout = (toplamk / kücük.Count) + (toplamb / büyük.Count);
            Console.WriteLine("İki listenin ortalamaları toplamı :"+cout);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{

    class Program
    {

        /*
         Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

                Negatif ve numeric olmayan girişleri engelleyin.
                Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
         
         */

        
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            for (int i = 1; i <=20; i++)
            {
                Console.Write(i+". sayi : ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi > 0 )
                {
                    int deger=asalMi(sayi);

                    if (deger == 0)
                        asal.Add(sayi);
                    else
                        asalDegil.Add(sayi);
                }
                else
                {
                    i--;
                }

            }
            asal.Sort();
            asal.Reverse();
            asalDegil.Sort();
            asalDegil.Reverse();

            
           
            int toplam = 0;
            for (int i = 0; i < asal.Count; i++)
            {
                toplam += Convert.ToInt32(asal[i]);
                Console.Write(asal[i]+"-");
            }
            int toplam2 = 0;
            for (int i = 0; i < asalDegil.Count; i++)
            {
                toplam2 += Convert.ToInt32(asalDegil[i]);
                Console.Write(asalDegil[i]+"-");
            }
            Console.WriteLine();
            Console.WriteLine("Asal sayılar listesi elemen sayısı :" + asal.Count + " ve ortalaması : " + toplam/asal.Count);
            Console.WriteLine("Asal olmayan sayılar listesinin elemen sayısı :" + asalDegil.Count +" ve ortalaması :"+toplam2/asalDegil.Count);





        }
        public static int asalMi(int sayi)
        {
            
            int kontrol = 0;
           
            int i = 2;
            while (i < sayi)
            {
                if (sayi % i == 0)
                    kontrol++;

                i++;
            }

            if (kontrol != 0)
                return kontrol;
            else
                return kontrol;



            

        }
    }
}

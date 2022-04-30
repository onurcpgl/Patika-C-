using System;

namespace Soru2
{
    class Program
    {
        /*
         Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif iki sayı giriniz:");
            Console.Write("1. Sayi: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2. Sayi: ");
            int m = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(n+"Adet sayı giriniz...");
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine((i+1)+".Sayi :");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            bolunuyorMu(n, m, dizi);
        }

        public static void bolunuyorMu(int n,int m,params int[] dizi)
        {
            foreach (var item in dizi)
            {
                if (item == m || item % m == 0)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}

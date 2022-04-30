using System;

namespace Soru3
{
    class Program
    { 
        /*
         
         Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write((i+1)+". değeri giriniz :");
                dizi[i] = Console.ReadLine();
            }
            Console.Clear();
            ArrayReverse(dizi);
            EkranaYaz(dizi);
            Console.ReadLine();


        }

        public static string[] ArrayReverse(params string[] dizi)
        {
            Array.Reverse(dizi);
            return dizi;
        }
        public static void EkranaYaz(params string[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}

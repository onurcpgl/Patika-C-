using System;

namespace Soru4
{
    class Program
    {
        /*
         Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz:");
            string cümle = Console.ReadLine();
            cumleSayisi(cümle);
        }
        public static void cumleSayisi(string a)
        {
            string[] kelimeler = a.Split(' ');
            Console.WriteLine("Kelimedeki cümle sayısı "+kelimeler.Length);
        }
        public static void kelimeSayisi(string a)
        {
            string[] kelimeler = a.Split("");
            Console.WriteLine(kelimeler.Length);
        }
    }
}

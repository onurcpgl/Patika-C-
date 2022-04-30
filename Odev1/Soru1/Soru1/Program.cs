using System;

namespace Soru1
{
    class Program
    {
        /*
         Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
         */
        static void Main(string[] args)
        {
            int[] dizi = new int[3];

            for (int i = 0; i <3; i++)
            {
                Console.Write("Lütfen pozitif bir sayı giriniz :");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            ciftSayilar(dizi);
            
            Console.ReadLine();
            

        }
        public static void ciftSayilar(params int[] param)
        {
            foreach (var item in param)
            {
                if (item % 2==0)
                {
                    Console.WriteLine(item);
                }             
            }
        }
    }
}

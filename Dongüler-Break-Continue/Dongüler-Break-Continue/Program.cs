using System;

namespace Dongüler_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("10 defa ekrana yazdırır");

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("10 defa ekrana yazdırır");
                if (i==4)
                {
                    break; // i=4 ise döngüden çıkarır.
                }
                continue; // Devam ettir. Durma devam et demektir.
            }
        }
    }
}

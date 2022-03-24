using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            //Toplama +
            a++;//artırma işlemi
            int sonuc = a + b; 
            int sonuc2 = a * b;//Çarpam
            int sonuc3 = a / b;//Bölme
            if (b==a)//Bool döndürür eşitse true eşit değilse false döndürür.
            {
                Console.WriteLine("Eşit değildir.");

            }
            a--;//azaltma işlemi 1 çıkarır ++ 1 artırır..

        }
    }
}

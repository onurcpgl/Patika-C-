using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanımlamaErişimDöngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim

            renkler[0] = "mavi";

            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            //Döngüler ile erişim

            for (int i = 0; i < hayvanlar.Length; i++)
            {
                Console.WriteLine(hayvanlar[i]);
            }

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }





        }
    }
}

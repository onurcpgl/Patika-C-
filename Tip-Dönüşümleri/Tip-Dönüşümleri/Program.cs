using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //İmplicit Conversion Bilinçsiz dönüşümler
            byte a = 5;
            sbyte b = 5;
            short c = 4;
            int d = a + b + c;
            long h = d;

            string ad= "Zikriye";
            char k = 'f';


            // Explicit Conversion Bilincsiz dönüşüm
            int x = 4;
            byte y = (byte)x;

            int z = 100;
            byte v = (byte)z;

            float w = 10.3f;
            byte p = (byte)w;

            //ToString metodu
            int xx = 6;
            string yy = xx.ToString();

            string zz = 12.5f.ToString();
            //System convert

            string s1 = "10", s2 = "5";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            


        }
    }
}

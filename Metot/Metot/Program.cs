using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(Convert.ToInt32(sonuc));

            Metotlar metot = new Metotlar();
            metot.EkranaYazdir(Convert.ToString(sonuc));

            Console.WriteLine(a+b);
            int sonuc2 = metot.ArttırVeriTopla(a,b);

        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeriTopla(int a,int b)
        {
            a += 1;
            b += 1;
            return a + b;
        }
    }
}

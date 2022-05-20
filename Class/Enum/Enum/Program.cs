using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 27;
            if (sıcaklık <=(int)HavaSıcaklıgı.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmaısnı bekleyin");

            }
            else if (sıcaklık >=(int)HavaSıcaklıgı.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            }
            else if (sıcaklık >=(int)HavaSıcaklıgı.Normal && sıcaklık<(int)HavaSıcaklıgı.Sıcak)
            {
                Console.WriteLine("Hadi Dışarı Çıkalım.. !! ");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaSıcaklıgı
    {
        Soguk =5,
        Normal=20,
        Sıcak=30
    }
}

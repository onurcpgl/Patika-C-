using System;

namespace Karar_Yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 5;

            if (b!=a)
            {
                Console.WriteLine("B A'ya eşit değildir.");
            }
            if (a == b + 5) Console.WriteLine("A eşit değildir b'ye");

            if (a<5)
            {
                //A kücükse 5'den
            }
            else if(a>5)
            {
                //A büyükse 5'den
            }
            else
            {
                //Hiç bir durumda 
            }

            Console.WriteLine("Haftanın kaçıncı günü");
            int gun = int.Parse(Console.ReadLine());
            switch (gun)
            {
                case 1: 
                    Console.WriteLine("Pazartesi"); 
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;



            }

        }
    }
}

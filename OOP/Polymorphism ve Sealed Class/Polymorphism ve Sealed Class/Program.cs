using System;

namespace Polymorphism_ve_Sealed_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();

            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("----------------------------");

            Kuşlar martı = new Kuşlar();

            martı.Ucmak();
        }
    }
}

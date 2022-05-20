using System;

namespace Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus mk1 = new Focus();
            Console.WriteLine(mk1.HangiMarkanınAracı());
            Console.WriteLine(mk1.KacTekerlektenOlusur());
            Console.WriteLine(mk1.StandartRengiNe());

            Civic fd5 = new Civic();
            Console.WriteLine(fd5.HangiMarkanınAracı());
            Console.WriteLine(fd5.KacTekerlektenOlusur());
            Console.WriteLine(fd5.StandartRengiNe());
            Console.ReadLine();
        }
    }
}

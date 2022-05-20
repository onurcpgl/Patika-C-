using System;

namespace Struct_Yapı__Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı : {0}",dikdortgen.AlanHesapla());

            //Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
            Dikdortgen_Struct dikdortgen_struct; //Nesne oluşturmadan da kullanılabilir bu şekilde structlar...
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_struct.AlanHesapla());

            //Bu şekilde de kullanılabilir.
            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_Struct.AlanHesapla());
            
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        //Bunu yapmana izin vermez.
        //public Dikdortgen_Struct()
        //{
        //    KisaKenar = 3;
        //    UzunKenar = 4;
        //}
        public Dikdortgen_Struct(int kısaKenar,int uzunKener)
        {
            this.KisaKenar = kısaKenar;
            this.UzunKenar = uzunKener;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}

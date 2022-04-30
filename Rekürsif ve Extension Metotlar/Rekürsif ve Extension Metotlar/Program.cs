using System;

namespace Rekürsif_ve_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metot
            string ifade = "Zikriye Ürkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhithSpaces());
            }
            Console.WriteLine(ifade.MakeLowerCase());
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYaz();
            
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs<2)
            {
                return sayi;
            }else
            {
                return Expo(sayi, üs - 1) * sayi;
            }
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhithSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;

        }
        public static void EkranaYaz(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool isEvenNumber(this int param)
        {
            return param % 2== 0; 
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1); //İlk karakteri alır.
        }
    }
}

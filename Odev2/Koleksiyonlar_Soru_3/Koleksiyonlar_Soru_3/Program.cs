using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {

        /*
         
         Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
         
         */
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            
            ArrayList sesli = new ArrayList { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            ArrayList dizi = new ArrayList();
            foreach (char karakter in cumle)
            {
                foreach (char ses in sesli)
                {
                    if (karakter == ses)
                    {
                        dizi.Add(ses);
                    }
                }
            }
            dizi.Sort();

            foreach (char item in dizi)
            {
                Console.Write(item+"-");
            }
        }
    }
}

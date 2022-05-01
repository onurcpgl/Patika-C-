using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp,Hoşgeldiniz !";
            string degisken2 = "Dersimiz CSharp";

            //Length

            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat

            Console.WriteLine(String.Concat(degisken,"MERHABA"));

            //Compare , CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains

            Console.WriteLine(degisken.Contains(degisken2)); //Bulursa true bulamazsa false.
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); 
            Console.WriteLine(degisken.StartsWith("Merhaba !!"));

            //İndexof  Aradığımız değer kaçıncı karakterde. değerini verir.

            Console.WriteLine(degisken2.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("MERHABA"));

            //Insert

            Console.WriteLine(degisken2.Insert(0,"Merhaba")); //  0.İndeksten başla bunu ekle demek
            
            //LastIndexOf
            Console.WriteLine(degisken2.LastIndexOf("i")); //Son indeksteki i yi getirir.

            //PadLeft PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30)); // 30' tamamlayacak kadar boslk ekler ve deger2 yi yazar.
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //Buda yıldız ekler boşlk yerne
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove

            Console.WriteLine(degisken2.Remove(10));
            Console.WriteLine(degisken2.Remove(5,3));
            Console.WriteLine(degisken2.Remove(0,1));

            //Replace

            Console.WriteLine(degisken.Replace("CSharp","C#")); //Baştakini sil bunu koy demek aslıda.
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split

            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));


            Console.ReadLine();


        }
    }
}

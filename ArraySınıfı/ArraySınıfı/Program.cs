using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySınıfı
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] dizi2 = new int[5];
            Array.Sort(dizi);//Diziyi kücükten büyüge sıralarr
            Array.Reverse(dizi);//Diziyi ters çevirir.
            Array.Copy(dizi, dizi2, 2); // birini diziye ikinci diziye ilk 2 tanesini kopyalar.
            Array.IndexOf(dizi,5);//5 sayısı içinde varsa true değeri yoksa false değeri döner



        }
    }
}

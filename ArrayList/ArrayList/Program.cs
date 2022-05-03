using System;
using System.Collections;
using System.Collections.Generic;


namespace ArrayListCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(10);
            liste.Add(true);
            liste.Add('A');

            //İcerisindeki verilere bakalım
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange birden fazla elemanı toplu ekleme
            Console.WriteLine("**** Add Range ****");

            string[] renkler = {"Kırmızı","Sarı","Yeşil"};

            List<int> sayılar = new List<int>() {1,8,3,7,9,92,5};

            liste.AddRange(sayılar);
            liste.AddRange(renkler);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort sıralama
            Console.WriteLine("**** Sort ****");
            //Sadece aynı tür elemanlar varsa sıralama yapar yoksa yapmaz.
            liste.Sort();

            //Binary Search önce sırala sonra kullan bunu

            Console.WriteLine("**** BinarySearch ****");
            Console.Write(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("**** Reverse ****");

            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear

            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}

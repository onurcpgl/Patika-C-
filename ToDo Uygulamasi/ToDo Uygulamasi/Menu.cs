using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Menu
    {
        public static void menuGoster(List<ToDo> list)
        {
            int secim = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seciniz...");
                Console.WriteLine(" ******************************************* ");

                Console.WriteLine(" (1) Board Listelemek");
                Console.WriteLine(" (2) Board'a Kart Eklemek");
                Console.WriteLine(" (3) Board'dan kart silmek");
                Console.WriteLine(" (4) Kart Taşımak");
                Console.WriteLine(" (5) Çıkış ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1: Islemler.kartListele(list); break;
                    case 2: Islemler.kartEkle(list); break;
                    case 3: Islemler.kartsil(list); break;
                    case 4: Islemler.kartTaşı(list); break;
                }
            } while (secim != 5);

            Console.ReadLine();
           

        }
    }
}

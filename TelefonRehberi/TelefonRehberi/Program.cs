using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TelefonRehberi
{
    
    class Program
    {
        OleDbConnection bag =new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =telDB.mdb");
        static void Main(string[] args)
        {
            List<Kisi> kisiListesi = new List<Kisi>();
            Kisi onur = new Kisi();
            onur.Isim = "Onur";
            onur.SoyIsim = "ÇÖPOĞLU";
            onur.TelNo = 535789;

            Kisi emir = new Kisi();
            emir.Isim = "Emir";
            emir.SoyIsim = "ÇÖPOĞLU";
            emir.TelNo = 535778;

            Kisi mahmut = new Kisi();
            mahmut.Isim = "Mahmut";
            mahmut.SoyIsim = "ÇÖPOĞLU";
            mahmut.TelNo = 535698;

            Kisi batu = new Kisi();
            batu.Isim = "Batu";
            batu.SoyIsim = "Ahmet";
            batu.TelNo = 535123;

            Kisi süleyman = new Kisi();
            süleyman.Isim = "Süleyman";
            süleyman.SoyIsim = "Emir";
            süleyman.TelNo = 536456;

            kisiListesi.Add(onur);
            kisiListesi.Add(emir);
            kisiListesi.Add(mahmut);
            kisiListesi.Add(batu);
            kisiListesi.Add(süleyman);


            Menu menu = new Menu();
            Menu.menuSayfa(kisiListesi);

            
            Console.ReadLine();
        }

        
    }
}

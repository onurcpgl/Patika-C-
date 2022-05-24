using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Kisi
    {
        private string isim;
        private string soyisim;
        private int telno;

        public void kisi(string ad,string soyisim,int no)
        {
            this.isim = ad;
            this.soyisim = soyisim;
            this.telno = no;
        }
        public void kisi()
        {

        }
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string SoyIsim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        public int TelNo
        {
            get { return telno; }
            set { telno = value; }
        }
    }
}

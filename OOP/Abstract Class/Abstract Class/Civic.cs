using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Civic : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}

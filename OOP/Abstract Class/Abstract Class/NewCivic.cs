using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class NewCivic : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Yeşil;
        }
    }
}

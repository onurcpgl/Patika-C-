using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class NewFocus : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Yeşil;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar.");
        }
        protected void Bosaltım()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }
    }
}

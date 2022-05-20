using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ve_Sealed_Class
{
    // sealed kalıtımı engeller bundan kalıtım yapılmasın demek.
    //public sealed class Canlilar
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
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}

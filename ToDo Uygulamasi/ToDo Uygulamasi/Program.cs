using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<ToDo> todo = new List<ToDo>();
            
            Menu.menuGoster(todo);

        }
    }
}

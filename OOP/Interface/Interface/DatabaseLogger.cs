using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}

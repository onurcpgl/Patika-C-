using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Loggers
{
    public class Old_DatabaseLogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Database");
        }
    }
}

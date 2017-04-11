using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Loggers
{
    public class Old_EventLogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EventLogger");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Loggers
{
    class New_EventLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EventLogger");
        }
    }
}

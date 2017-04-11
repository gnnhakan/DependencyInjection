using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Loggers
{
    
    public class NinjectFactory
    {
        private IKernel _kernel;

        public NinjectFactory()
        {
            _kernel = new StandardKernel();

            
            _kernel.Bind<ILogger>().To<New_EventLogger>(); // only change DatabaseLogger, EventLogger, FileLogger etc.
        }
    }
}

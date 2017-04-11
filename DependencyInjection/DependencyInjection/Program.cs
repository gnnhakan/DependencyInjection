using DependencyInjection.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
       

        static void Main(string[] args)
        {
            /* Solid (Dependency Inversion does not implemented :( )
            when we want to change logger type such as Databaselogger, FileLogger or ThirtParty Logger. 
            we must to change all EventLogger to Database Logger etc.. */

            //OldMethod();

            /* Solid (Dependency Inversion does implemented :) )
             how is possible to write clean code. 
               --do Abstraction your object   
               --use Dependency Injection pattern   
               --Inversion of Control (IOC), use IoC Container (Ninject ,Castle, Windsor , Unity from Nuget)
               
               */
            //NewMethod(); ///hknhkn check later
            Console.ReadKey();

        }

        public static void NewMethod()
        {
            //_kernel.Bind<ILogger>().To<New_DatabaseLogger>();
            _logger.Log();  //if you want to change log type look NinjectFactory
        }
        
        private static void OldMethod()
        {
            var logger = new Old_EventLogger();
            logger.Log();
        }



        private static ILogger _logger; // be caruful when you use MVC... use custom factory insead of default controller factory 

        public Program(ILogger logger)
        {
            _logger = logger;
        }

    }
}

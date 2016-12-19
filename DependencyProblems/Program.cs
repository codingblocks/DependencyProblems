using System;
using System.IO;
using log4net;
using log4net.Config;

namespace DependencyProblems
{
    class Program
    {
        // Define a static logger variable so that it references the
        // Logger instance named "MyApp".
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("logging.config"));

            log.Warn("test");
            log.Error("Just a test");
            Console.Write("Test");
            Console.ReadKey();

            var person = new Core.Models.Person("Allen", "Underwood", 21, "Male");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServerTCP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //string ruta = "C:\\Users\\s58802\\Desktop\\ServerTCP\\ServerTCP\\bin\\Debug\\Server.config";// System.Reflection.Assembly.GetExecutingAssembly().+"\\Server.config";
            //RemotingConfiguration.Configure(ruta, false);
            //Console.WriteLine("El servicio inicio correctamente");
            //Console.ReadKey();
          //  string ruta= System.IO.Directory.GetCurrentDirectory().ToString();
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServerTCP()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}

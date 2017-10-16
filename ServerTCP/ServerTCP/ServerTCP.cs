using System.ComponentModel;
using System.ServiceProcess;
using System.Runtime.Remoting;
using System.IO;

namespace ServerTCP
{
    public partial class ServerTCP : ServiceBase
    {       
        public ServerTCP()
        {
             InitializeComponent();          
        }

        protected override void OnStart(string[] args)
        {
            string ruta = System.Configuration.ConfigurationManager.AppSettings["RutaServerConfig"].ToString();            
            RemotingConfiguration.Configure(ruta, false);
        }

        protected override void OnStop()
        {

        }
    }
}

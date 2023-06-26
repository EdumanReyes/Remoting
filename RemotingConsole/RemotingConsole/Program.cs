using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RemotingConsole
{
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
           // Registro de comunicación HTTP
            ChannelServices.RegisterChannel(new HttpChannel(8081));

            // Registro de objeto remoto
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(MessageService),
                "MessageService",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("El servidor está en Linea...\n\n Presiona Enter para salir.");
            Console.ReadLine();
        }
    }
}

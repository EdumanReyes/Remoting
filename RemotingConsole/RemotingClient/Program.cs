using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using RemotingConsole;

namespace RemotingClient
{
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            // Registro de canal HTTP
            ChannelServices.RegisterChannel(new HttpChannel());

            // Proxy para objeto remoto
            IMessageService messageService = (IMessageService)Activator.GetObject(
                typeof(IMessageService),
                "http://localhost:8081/MessageService");

            // Realizar interacciones con el servidor
            string response = messageService.GetMessage();
            Console.WriteLine("Respuesta del servidor: " + response);

            messageService.SendMessage("¡Este es un mensaje enviado desde el cliente!");

            Console.WriteLine("Presiona Enter para salir.");
            Console.ReadLine();
        }
    }
 }


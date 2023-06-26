using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingConsole
{
    public class MessageService : MarshalByRefObject, IMessageService
    {
        public string GetMessage()
        {
            Console.WriteLine("Mensaje recibido en el servidor");
            return "¡Hola bienvenido, este es un mensaje enviado desde el servidor!";
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Mensaje recibido en el servidor: " + message);
        }
    }
}

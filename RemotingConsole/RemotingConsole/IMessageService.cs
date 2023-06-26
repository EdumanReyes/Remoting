using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingConsole
{
    public interface IMessageService
    {
        string GetMessage();
        void SendMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditContent
{
    public class Server : IPrepare
    {
        public void Send(string userInput)
        {
            Console.WriteLine("已发送至服务器。");
        }
    }
}

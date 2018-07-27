using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandService
{
    public class Say : ICommand
    {
        public string Do(string parameters)
        {
            return "已将消息“" + parameters + "”发送给对方！";
        }
    }
}

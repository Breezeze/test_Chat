using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class SayCommand : ICommand
    {
        public string Do(string parameters)
        {
            return "已将消息“" + parameters + "”发送给对方！";
        }
    }
}

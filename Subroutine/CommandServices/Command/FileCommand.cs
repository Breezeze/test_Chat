using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class FileCommand : ICommand
    {
        public  string Do(string parameters)
        {
            return "已将路径为“" + parameters + "”的文件发送给对方！";
        }
    }
}

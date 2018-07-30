using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class FileCommand : ICommand
    {
        public string CommandName { get { return "file"; } }
        public string Behavior { get { return "文件发送"; } }
        public bool IsStore { get { return true; } }

        public void Do(params string[] parameter)
        {
            Console.WriteLine("已将路径为“" + parameter[0] + "”的文件发送给对方！");
        }
}
}

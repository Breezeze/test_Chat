using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class FileCommand : BaseCommand
    {
        public override string CommandName { get { return "file"; } }
        public override string Behavior { get { return "文件发送"; } }
        public override bool IsStore { get { return true; } }

        public override void Do(params string[] parameter)
        {
            Console.WriteLine("已将路径为“" + parameter[0] + "”的文件发送给对方！");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClass
{
    public class File : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", parameters);
        }
    }
}

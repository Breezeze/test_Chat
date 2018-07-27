using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutine
{

    public class say : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将消息“{0}”发送给对方！", parameters);
        }
    }
    public class file : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", parameters);
        }
    }
    public class music : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", parameters);
        }
    }
    public class acticle : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将名为“{0}”的文章推荐给对方！", parameters);
        }
    }
}

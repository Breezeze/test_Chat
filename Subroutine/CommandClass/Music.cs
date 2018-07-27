using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClass
{
    public class Music : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", parameters);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class MusicCommand : BaseCommand
    {
        public override string CommandName { get { return "music"; } }
        public override string Behavior { get { return "歌曲推荐"; } }
        public override bool IsStore { get { return true; } }

        public override void Do(params string[] parameter)
        {
            Console.WriteLine("已将名为“" + parameter[0] + "”的歌曲推荐给对方！");
        }
    }
}

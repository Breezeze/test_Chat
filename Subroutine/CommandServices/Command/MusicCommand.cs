using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class MusicCommand : BaseCommand
    {
        public override string CommandName => "music";
        public override string Behavior => "歌曲推荐";
        protected override bool IsStorable => true;
        protected override int MaxParaNum => 1;
        protected override int MinParaNum => 1;

        protected override void Do()
        {
            Console.WriteLine("已将名为“" + parameters[0] + "”的歌曲推荐给对方！");
        }
    }
}

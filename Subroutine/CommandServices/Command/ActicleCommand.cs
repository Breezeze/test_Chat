using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class ActicleCommand : BaseCommand
    {
        public override string CommandName { get { return "acticle"; } }
        public override string Behavior { get { return "文章分享"; } }
        protected override bool IsStorable { get { return true; } }
        protected override int MaxParaNum { get { return 1; } }
        protected override int MinParaNum { get { return 1; } }

        protected override void Do()
        {
            Console.WriteLine("已将名为“" + parameters[0] + "”的文章推荐给对方！");
        }
    }
}

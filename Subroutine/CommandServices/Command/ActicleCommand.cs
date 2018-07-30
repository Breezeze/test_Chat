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
        public override bool IsStore { get { return true; } }

        public override void Do(params string[] parameter)
        {
            Console.WriteLine("已将名为“" + parameter[0] + "”的文章推荐给对方！");
        }
    }
}

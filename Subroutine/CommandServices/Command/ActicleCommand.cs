using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class ActicleCommand : ICommand
    {
        public string CommandName { get { return "acticle"; } }
        public string Behavior { get { return "文章分享"; } }
        public bool IsStore { get { return true; } }

        public void Do(params string[] parameter)
        {
            Console.WriteLine("已将名为“" + parameter[0] + "”的文章推荐给对方！");
        }
    }
}

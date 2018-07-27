using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClass
{
    public class Acticle : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将名为“{0}”的文章推荐给对方！", parameters);
        }
    }
}

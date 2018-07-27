using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClass
{
    public class Say : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("已将消息“{0}”发送给对方！", parameters);
        }
    }
}

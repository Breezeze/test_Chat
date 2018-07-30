using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class SayCommand : BaseCommand
    {
        public override string CommandName { get { return "say"; } }
        public override string Behavior { get { return "消息发送"; } }
        public override bool IsStore { get { return true; } }

        public override void Do(params string[] parameter)
        {
            Console.WriteLine("已将消息“" + parameter[0] + "”发送给对方！");
        }
    }
}

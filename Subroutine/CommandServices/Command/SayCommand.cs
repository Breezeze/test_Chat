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
        protected override bool IsStorable { get { return true; } }
        protected override int MaxParaNum { get { return 1; } }
        protected override int MinParaNum { get { return 1; } }

        protected override void Do()
        {
            Console.WriteLine("已将消息“" + parameters[0] + "”发送给对方！");
        }
    }
}

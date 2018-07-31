using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class FileCommand : BaseCommand
    {
        public override string CommandName => "file";
        public override string Behavior => "文件发送";
        protected override bool IsStorable => true;
        protected override int MaxParaNum => 1;
        protected override int MinParaNum => 1;

        protected override void Do()
        {
            Console.WriteLine("已将路径为“" + parameters[0] + "”的文件发送给对方！");
        }
    }
}

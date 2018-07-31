using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices.Command
{
    public class ShowCMD : BaseCommand
    {
        public override string CommandName => "CMD";
        public override string Behavior => "获取CMD格式";
        protected override bool IsStorable => false;
        protected override int MaxParaNum => 0;
        protected override int MinParaNum => 0;

        /// <summary>
        /// 存储所有指令集名字
        /// </summary>
        public string[] CommandsName { get; set; }

        protected override void Do()
        {
            if (parameters != null)
            {
                throw new Exception(CommandName + "指令无参数！请重试！");
            }
            string _tip = "命令行语法为：\n 1. 命令行关键字 + 关键词参数 + \":\" + 参数\n2. 命令行关键词\n"
                       + "命令行关键字有：\n";
            for (int i = 0; i < CommandsName.Length; i++)
            {
                _tip += CommandsName[i] + "\t\t";
                if (i % 4 == 3)
                {
                    _tip += "\n";
                }
            }
            _tip += "\n例如：“say:hello world”  表示发送消息“hello world”给对方\n“file:C:\\123.txt” 表示把 123.txt 文件发送给对方";
            Console.WriteLine(_tip);
        }
    }
}

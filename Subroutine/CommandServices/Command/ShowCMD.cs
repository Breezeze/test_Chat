using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices.Command
{
    public class ShowCMD : BaseCommand
    {
        public override string Behavior { get { return "获取CMD格式"; } }
        public override string CommandName { get { return "CMD"; } }
        public override bool IsStore { get { return false; } }

        public  string[] CommandsName { get; set; }

        public override void Do(params string[] parameters)
        {
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

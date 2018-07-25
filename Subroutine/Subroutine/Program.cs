using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("提示：命令行语法请输入“CMD”进行查看！");
            string msg;
            do
            {
                msg = Console.ReadLine();
                if (msg == "CMD")
                {
                    string tip = "命令行语法为： 命令行关键字 + 关键词参数 + \":\" + 参数\n"
                               + "命令行关键字有：say,file,music等\n例如：“say:hello world”  表示发送消息“hello world”给对方\n“file:C:\\123.txt” 表示把 123.txt 文件发送给对方";
                    Console.WriteLine(tip);
                }
                else
                {
                    Chat(msg);
                }
            } while (msg != "exit");



        }


        /// <summary>
        /// 解析命令行
        /// </summary>
        /// <param name="str"></param>
        public static void Chat(string str)
        {
            try
            {
                int index = str.IndexOf(':');
                string cmd = str.Substring(0, index);
                string msg = str.Substring(index + 1);
                switch (cmd)
                {
                    case "say":
                        //发送字符串给指定好友
                        Console.WriteLine("已将消息“{0}”发送给对方！", msg);
                        break;
                    case "file":
                        if (File.Exists(msg))
                        {
                            //发送文件
                            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", msg);
                        }
                        else
                        {
                            Console.WriteLine("请检查该文件（“{0}”）是否存在！", msg);
                        }
                        break;
                    case "music":
                        Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", msg);
                        break;
                    case "acticle":
                        Console.WriteLine("已将名为“{0}”的文章推荐给对方！", msg);
                        break;
                    default:
                        Console.WriteLine("未知命令“{0}”！", str);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("未知命令“{0}”！", str);
            }
        }
    }
}


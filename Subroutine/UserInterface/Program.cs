using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UserInterface
{
    class Program
    {

        static void Main(string[] args)
        {
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (userInput == "CMD")
                {
                    string _tip = "命令行语法为： 命令行关键字 + 关键词参数 + \":\" + 参数\n"
                               + "命令行关键字有：say,file,music等\n例如：“say:hello world”  表示发送消息“hello world”给对方\n“file:C:\\123.txt” 表示把 123.txt 文件发送给对方";
                    Console.WriteLine(_tip);
                }
                else
                {
                    try
                    {
                        int colonIndex = userInput.IndexOf(':');
                        string cmd = userInput.Substring(0, colonIndex);
                        string parameter = userInput.Substring(colonIndex + 1);
                        string msg = CommandProcessor.AnalysisCode.AnalysisUserInput(cmd, parameter);
                        Console.WriteLine(msg);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("请输入正确的指令格式！");
                    }
                }
            } while (userInput != "exit");

        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Subroutine
{
    class Program
    {

        static void Main(string[] args)
        {
            string _userInput;
            do
            {
                _userInput = Console.ReadLine();
                if (_userInput == "CMD")
                {
                    string _tip = "命令行语法为： 命令行关键字 + 关键词参数 + \":\" + 参数\n"
                               + "命令行关键字有：say,file,music等\n例如：“say:hello world”  表示发送消息“hello world”给对方\n“file:C:\\123.txt” 表示把 123.txt 文件发送给对方";
                    Console.WriteLine(_tip);
                }
                else
                {
                    Console.WriteLine(MountCommand.Analysis.AnalysisCode(_userInput));
                }
            } while (_userInput != "exit");

        }

    }
}



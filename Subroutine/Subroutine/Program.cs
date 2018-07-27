using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CommandClass;

namespace Subroutine
{
    class Program
    {
        private static List<Type> _subClassList;

        static void Main(string[] args)
        {
            string _userInput;
            Initialize();
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
                    AnalysisCode(_userInput);
                }
            } while (_userInput != "exit");

        }

        private static void Initialize()
        {
            _subClassList = (from t in Assembly.LoadFrom("CommandClass.dll").GetTypes()
                             where IsSubClass(t, typeof(Command))
                             select t).ToList();
            Console.WriteLine("提示：命令行语法请输入“CMD”进行查看！");
        }

        static bool IsSubClass(Type type, Type baseType)
        {
            var b = type.BaseType;
            while (b != null)
            {
                if (b.Equals(baseType))
                {
                    return true;
                }
                b = b.BaseType;
            }
            return false;
        }


        /// <summary>
        /// 解析命令行
        /// </summary>
        /// <param name="userInput"></param>
        public static void AnalysisCode(string userInput)
        {
            try
            {
                int colonIndex = userInput.IndexOf(':');
                string cmd = userInput.Substring(0, colonIndex);
                string msg = userInput.Substring(colonIndex + 1);

                #region 初始版本

                //switch (cmd)
                //{
                //    case "say":
                //        //发送字符串给指定好友
                //        Console.WriteLine("已将消息“{0}”发送给对方！", msg);
                //        break;
                //    case "file":
                //        if (File.Exists(msg))
                //        {
                //            //发送文件
                //            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", msg);
                //        }
                //        else
                //        {
                //            Console.WriteLine("请检查该文件（“{0}”）是否存在！", msg);
                //        }
                //        break;
                //    case "music":
                //        Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", msg);
                //        break;
                //    case "acticle":
                //        Console.WriteLine("已将名为“{0}”的文章推荐给对方！", msg);
                //        break;
                //    default:
                //        Console.WriteLine("未知命令“{0}”！", str);
                //        break;
                //}

                #endregion

                foreach (Type type in _subClassList)
                {
                    if (type.Name.ToLower() == cmd.ToLower())
                    {
                        object objSubClass = Activator.CreateInstance(type);
                        ((Command)objSubClass).Do(msg);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("未知命令“{0}”！", userInput);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chattools.cs
{
    public static class FunctionClass
    {
        /// <summary>
        /// 选择操作码
        /// </summary>
        /// <param name="func1"></param>
        /// <param name="func2"></param>
        /// <param name="func3"></param>
        /// <returns></returns>
        public static int Choose(T1Delegate func1, T1Delegate func2, T1Delegate func3)
        {
            while (true)
            {
                string choose = Console.ReadKey().Key.ToString();
                switch (choose)
                {
                    case "D1":
                    case "NumPad1":
                        return func1();
                    case "D2":
                    case "NumPad2":
                        return func2();
                    case "D3":
                    case "NumPad3":
                        if (func3 != null)
                            return func3();
                        else
                        {
                            Console.WriteLine("\n您输入了无法识别的操作码“" + choose + "”，系统无法识别，请重新输入：");
                            break;
                        }
                    default:
                        Console.WriteLine("\n您输入了无法识别的操作码“" + choose + "”，系统无法识别，请重新输入：");
                        break;
                }
            }
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
                string par = str.Substring(index + 1);
                Console.WriteLine(cmd);
                Console.WriteLine(par);
                switch (cmd)
                {
                    case "say":
                        //发送字符串给指定好友
                        Console.WriteLine("已将消息“{0}”发送给对方！", par);
                        break;
                    case "file":
                        if (File.Exists(par))
                        {
                            //发送文件
                            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", par);
                        }
                        else
                        {
                            Console.WriteLine("请检查该文件（“{0}”）是否存在！", par);
                        }
                        break;
                    case "music":
                        Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", par);
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

        public static int Login_0_1()
        {
            Console.Write("\n请输入您的账号：");
            string acc = Console.ReadLine();
            Console.Write("请输入您的密码：");
            string pwd = Console.ReadLine();
            User a = User.Login(acc, pwd);
            if (a != null)
            {
                Program.LoginUser = a;
                Console.WriteLine("恭喜您，登陆成功！");
                return 1;
            }
            else
            {
                Console.WriteLine("\n账号或密码错误，返回主菜单！\n");
                Console.ReadKey();
                return 0;
            }
        }

        public static int Exit_0_2()
        {
            System.Threading.Thread.CurrentThread.Abort();//进程已结束
            return -1;
        }

        public static int ExamineFriend_1_1()
        {
            Console.WriteLine("\n好友列表：\n");
            Console.WriteLine("好友id\t好友名\n");
            Program.LoginUser.Friends.ForEach(a => Console.WriteLine(a.ToString()));
            return 2;
        }

        public static int LogOut_1_2()
        {
            Program.LoginUser = null;
            return 0;
        }

        public static int ChooseFriendId_2_1()
        {
            Console.WriteLine("\n请输入你选择要操作好友的id：");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (User item in Program.LoginUser.Friends)
                {
                    if (item.Nid == id)
                        return 3;
                }
                Console.WriteLine("\n未找到该好友，请输入正确的好友id!");
                return ChooseFriendId_2_1();
            }
            catch (Exception)
            {
                Console.WriteLine("请输入数字，重新输入\n");
                return ChooseFriendId_2_1();
            }
        }

        public static int GoBack()
        {
            Console.WriteLine("\n已返回到主菜单\n");
            return 1;
        }

        public static int StartCommunication_3_1()
        {
            Console.WriteLine("\n已经建立对话连接，请使用命令行进行对话！");
            Console.WriteLine("提示：命令行语法请输入“CMD”进行查看！");
            string msg;
            do
            {
                msg = Console.ReadLine();
                if (msg == "CMD")
                {
                    string tip = "命令行语法为： 命令行关键字 + \":\" + 参数\n"
                               + @"命令行关键字有：say,file,music等
例如：“say:hello world”  表示发送消息“hello world”给对方
“file:C:\123.txt” 表示把 123.txt 文件发送给对方
";
                    Console.WriteLine(tip);
                }
                else
                {
                    Chat(msg);
                }
            } while (msg != "exit");
            return 1;
        }

        public static int DeleteFriend_3_2()
        {
            User dele = null;
            foreach (User item in Program.LoginUser.Friends)
            {
                if (item.Nid == Program.LoginUser.NowDialogue)
                    dele = item;
            }
            Program.LoginUser.Friends.Remove(dele);
            Console.WriteLine("已将该好友删除，返回主菜单！");
            return 1;
        }



    }
}

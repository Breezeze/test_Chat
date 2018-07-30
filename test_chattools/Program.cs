using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_ChatTools.cs;

namespace Test_ChatTools
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        /// <summary>
        /// 当前登陆用户
        /// </summary>
        public static User LoginUser { get; set; }



        /// <summary>
        /// 主要流程：
        /// 登陆=》查看好友=》选择好友建立对话框=》输入聊天指令与内容=》关闭对话框=》退出（先登出后退出）
        /// </summary>
        public static void Start()
        {
            int result = 0;
            while (result != -1)
            {
                switch (result)
                {
                    case 0://登陆
                        Console.Write(Menu.Content0);
                        result = FunctionClass.Choose(FunctionClass.Login_0_1, FunctionClass.Exit_0_2, null);
                        break;
                    case 1://查看好友列表
                        Console.Write(Menu.Content1);
                        result = FunctionClass.Choose(FunctionClass.ExamineFriend_1_1, FunctionClass.LogOut_1_2, null);
                        break;
                    case 2://选择好友
                        Console.Write(Menu.Content2);
                        result = FunctionClass.Choose(FunctionClass.ChooseFriendId_2_1, FunctionClass.GoBack, null);
                        break;
                    case 3://选择对好友的操作
                        Console.Write(Menu.Content3);
                        result = FunctionClass.Choose(FunctionClass.StartCommunication_3_1, FunctionClass.DeleteFriend_3_2, FunctionClass.GoBack);
                        break;
                    default:
                        return;
                }
            }

            Console.WriteLine(Menu.Content1);
            //FunctionClass.Choose()


        }

    }
}

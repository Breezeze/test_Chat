using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chattools.cs
{
    public static class Menu
    {
        public static string Content0//初始
        {
            get
            {
                return "\n欢迎进入test聊天模拟器~\n"
                      + "菜单操作码如下：\n"
                      + "1.登陆\n"
                      + "2.退出\n"
                      + "请输入选择您的操作码:";
            }
        }
        public static string Content1//登陆后
        {
            get
            {
                return "\n主菜单操作码如下：\n"
                      + "1.查看好友列表\n"
                      + "2.登出\n"
                      + "请输入选择您的操作码:";
            }
        }
        public static string Content2//
        {
            get
            {
                return "\n好友列表操作码如下：\n"
                      + "1.选择好友，对好友进行操作\n"
                      + "2.返回主菜单：\n"
                      + "请输入选择您的操作码: ";
            }
        }
        public static string Content3//
        {
            get
            {
                return "\n好友功能操作码如下：\n"
                      + "1.建立聊天对话框\n"
                      + "2.删除该好友\n"
                      + "3.返回主菜单：\n"
                      + "请输入选择您的操作码: ";
            }
        }


    }
}

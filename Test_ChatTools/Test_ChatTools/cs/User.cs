using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ChatTools.cs
{
    public class User
    {
        public User() { }
        public User(string acc, string pwd)
        {
            this.Account = acc;
            this.Password = pwd;
            Friends = new List<User>() {
                new User() { Nid = 1001, Name = "张三" },
                new User() { Nid = 1002, Name = "李四" },
                new User() { Nid = 1003, Name = "赵五" }
            };
        }
        public string Account { get; set; }
        public string Password { get; set; }
        public int Nid { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 当前对话用户
        /// </summary>
        public int NowDialogue { get; set; }
        /// <summary>
        /// 好友列表
        /// </summary>
        public List<User> Friends { get; set; }
        /// <summary>
        /// 登陆状态：1为登陆，0为未登录
        /// </summary>
        int LoginStatus = 0;

        public static User Login(string account, string password)
        {
            switch (account)
            {
                case "1":
                    if (password == "1")
                        return new User(account, password) { LoginStatus = 1 };
                    break;
                case "2":
                case "fs":
                case "lr":
                case "admin":
                    if (password == account)
                        return new User(account, password) { LoginStatus = 1 };
                    break;
            }
            return null;
        }
        public override string ToString()
        {
            return this.Nid + "\t" + this.Name;
        }
    }
}

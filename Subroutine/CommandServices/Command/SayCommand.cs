using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class SayCommand : ICommand
    {
        public string CommandName { get { return "say"; } }
        public string Behavior { get { return "消息发送"; } }
        public bool IsStore { get { return true; } }

        public void Do(params string[] parameter)
        {
            Console.WriteLine("已将消息“" + parameter[0] + "”发送给对方！");
        }
    }
}

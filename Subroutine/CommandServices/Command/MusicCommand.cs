using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class MusicCommand : ICommand
    {
        public string CommandName { get { return "music"; } }
        public string Behavior { get { return "歌曲推荐"; } }
        public bool IsStore { get { return true; } }

        public void Do(params string[] parameter)
        {
            Console.WriteLine("已将名为“" + parameter[0] + "”的歌曲推荐给对方！");
        }
}
}

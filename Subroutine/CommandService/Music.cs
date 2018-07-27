using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandService
{
    public class Music : ICommand
    {
        public string Do(string parameters)
        {
            return "已将名为“" + parameters + "”的歌曲推荐给对方！";
        }
    }
}

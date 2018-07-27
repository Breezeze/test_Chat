using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandService
{
    public class Acticle : ICommand
    {
        public  string Do(string parameters)
        {
            return "已将名为“" + parameters + "”的文章推荐给对方！";
        }
    }
}

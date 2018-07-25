using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutine
{
    public abstract class Command
    {
        public Command() { }

        public virtual void Do(string parameters)
        {
            Console.WriteLine("能做什么");
        }
    }

    public class Say : Command
    {
        public override void Do(string parameters)
        {
            Console.WriteLine("发送了消息");
        }
    }


}

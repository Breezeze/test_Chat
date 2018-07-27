using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClass
{
    public abstract class Command
    {
        public virtual void Do(string parameters)
        {
            Console.WriteLine("能做什么");
        }
    }
}

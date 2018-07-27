using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    /// <summary>
    /// 指令实现
    /// </summary>
    public interface ICommand
    {
        string Do(string msg);
    }
}

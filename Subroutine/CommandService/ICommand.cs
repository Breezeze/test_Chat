using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandService
{
    public interface ICommand
    {
        string Do(string msg);
    }
}

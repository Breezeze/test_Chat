using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public interface IStore
    {
        /// <summary>
        /// 是否能够记录
        /// </summary>
        bool IsStore { get; }
        /// <summary>
        /// 是否记录
        /// </summary>
        void Store(string[] parameters);
    }
}

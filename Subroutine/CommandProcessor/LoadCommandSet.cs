using CommandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessor
{
    /// <summary>
    /// 读取CMD指令集
    /// </summary>
    public static class LoadCommandSet
    {
        /// <summary>
        /// 首次运行加载指令集，存入_subClassList
        /// </summary>
        static LoadCommandSet()
        {
            _subClassList = new Dictionary<string, ICommand>();
            System.Reflection.Assembly.LoadFrom("CommandServices.dll").GetTypes()//读取CommandService中的所有类
            .Where(t => t.GetInterfaces().Contains(typeof(ICommand))).ToList()//将实现ICommand接口的类存入集合
            .ForEach(type => _subClassList.Add(type.Name.ToLower(), (ICommand)Activator.CreateInstance(type)));//将集合中的每项元素存入_subClassList
        }

        private static Dictionary<string, ICommand> _subClassList;

        /// <summary>
        /// 根据指令关键词获取CMD处理程序
        /// </summary>
        /// <returns></returns>
        public static ICommand GetProcessClass(string typename)
        {
            typename = typename.ToLower() + "command";
            if (_subClassList.ContainsKey(typename))
            {
                return _subClassList[typename];
            }
            else
            {
                return null;
            }
        }

    }
}

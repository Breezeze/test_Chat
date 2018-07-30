using CommandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessor
{
    /// <summary>
    /// 读取CMD指令集类
    /// </summary>
    internal static class LoadCommandSet
    {
        /// <summary>
        /// 首次运行加载指令集，存入_subClassList
        /// </summary>
        static LoadCommandSet()
        {
            _subClassList = new Dictionary<string, ICommand>();
            string[] commandsName;

            List<Type> cmdTypeList = System.Reflection.Assembly.LoadFrom("CommandServices.dll").GetTypes()//读取CommandService中的所有类
              .Where(t => t.GetInterfaces().Contains(typeof(ICommand))).ToList();//将实现ICommand接口的类存入集合
            commandsName = new string[cmdTypeList.Count];
            for (int i = 0; i < cmdTypeList.Count; i++)//将集合中的每项元素存入_subClassList
            {
                ICommand cmdClass = (ICommand)Activator.CreateInstance(cmdTypeList[i]);
                _subClassList.Add(cmdClass.CommandName, cmdClass);
                commandsName[i] = cmdClass.CommandName;
            }
           ((CommandServices.Command.ShowCMD)_subClassList["CMD"]).CommandsName = commandsName;
        }

        private static Dictionary<string, ICommand> _subClassList;

        /// <summary>
        /// 根据指令关键词获取CMD处理程序
        /// </summary>
        /// <returns></returns>
        internal static ICommand GetProcessClass(string typename)
        {
            return _subClassList.ContainsKey(typename) ? _subClassList[typename] : null;
        }

    }
}

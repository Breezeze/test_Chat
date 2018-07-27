using CommandService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountCommand
{
    public static class LoadCommand
    {
        private static Dictionary<string, ICommand> _subClassList;

        /// <summary>
        /// 获取CMD处理类
        /// </summary>
        /// <returns></returns>
        public static ICommand GetProcessClass(string typename)
        {
            if (_subClassList == null)
            {
                _subClassList = new Dictionary<string, ICommand>();
                System.Reflection.Assembly.LoadFrom("CommandService.dll").GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommand))).ToList()
                .ForEach(type => _subClassList.Add(type.Name.ToLower(), (ICommand)Activator.CreateInstance(type)));
            }
            return _subClassList[typename];
        }

    }
}

using CommandServices;
using LogProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessor
{
    /// <summary>
    /// 代码分析类
    /// </summary>
    public static class AnalysisCode
    {
        /// <summary>
        ///  解析命令行
        /// </summary>
        /// <param name="userInput">用户输入</param>
        /// <returns></returns>
        public static bool AnalysisOneCode(string userInput)
        {
            string[] parameters;
            string cmd = SeparationCode(out parameters, userInput);
            ICommand cmdClass = null;

            if (LoadCommandSet.GetProcessClass(cmd) == null)
            {
                Console.WriteLine("未知命令“" + cmd + "”！");
                return false;
            }
            else
            {
                cmdClass = LoadCommandSet.GetProcessClass(cmd);
            }
            try
            {
                cmdClass.Do(parameters);
                if (cmdClass.IsStore)
                {
                    if (StoreLog.StoreExecutiveOutcome(cmdClass.CommandName, cmdClass.Behavior, parameters, true, null))
                    {
                        Console.WriteLine("日志记录成功。");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现无法处理的错误！请重试！\n错误信息为：" + ex.Message);
                if (StoreLog.StoreExecutiveOutcome(cmdClass.CommandName, cmdClass.Behavior, parameters, false, ex.Message))
                {
                    Console.WriteLine("已记录本次错误。");
                }
                return false;
            }
        }


        private static string SeparationCode(out string[] parameters, string userInput)
        {
            string cmd;
            int colonIndex = userInput.IndexOf(':');

            if (colonIndex != -1)
            {
                cmd = userInput.Substring(0, colonIndex);
                parameters = userInput.Substring(colonIndex + 1).Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                cmd = userInput;
                parameters = null;
            }
            return cmd;
        }
    }
}

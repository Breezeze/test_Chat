using AuditContent;
using CommandServices;
using System;

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
        public static void AnalysisOneCode(string userInput)
        {
            string[] parameters;
            string cmd = SeparationCode(out parameters, userInput);
            IPrepare prepare = new Admin();
            BaseCommand cmdClass = LoadCommandSet.GetProcessClass(cmd);

            prepare.Send(userInput);
            if (cmdClass == null)
            {
                Console.WriteLine("未知命令“" + cmd + "”！");
                return;
            }
            cmdClass.ExecuteOperation(parameters);
        }

        /// <summary>
        /// 分离用户输入的关键词和参数
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="userInput"></param>
        /// <returns></returns>
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

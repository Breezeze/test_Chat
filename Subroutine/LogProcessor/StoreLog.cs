using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogProcessor
{
    /// <summary>
    /// 日志存储类
    /// </summary>
    public static class StoreLog
    {
        /// <summary>
        /// 存储代码执行结果
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameter"></param>
        /// <param name="success"></param>
        /// <returns></returns>
        public static bool StoreExecutiveOutcome(string cmd, string behavior, string[] parameters, bool success, string FailedInfo)
        {
            string logPath = "ChatLog.txt";
            string msg = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");

            try
            {
                msg += "\r\n用户使用“" + cmd + "”命令，参数为：“" + parameters[0];
                for (int i = 1; i < parameters.Length; i++)
                {
                    msg += "， “" + parameters[i] + "”";
                }
                msg += "\r\n“" + behavior + "”" + (success ? "成功。\r\n" : "失败。\r\n原因是：" + FailedInfo + "。\r\n");
                using (FileStream fs = new FileStream(logPath, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(msg);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

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
        public static bool StoreExecutiveOutcome(string cmd, string behavior, string[] parameters, bool success, string FailedInfo)
        {
            string logPath = "ChatLog.txt";
            string msg = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");

            try
            {
                msg += "\r\n用户使用“" + cmd + "”命令";
                for (int i = 1; i < parameters.Length; i++)
                {
                    if (i == 0)
                    {
                        msg += " \n参数为：“" + parameters[i];
                    }
                    else
                    {
                        msg += "， “" + parameters[i] + "”";
                    }
                }
                msg += "\r\n“" + behavior + "”" + (success ? "成功。\r\n" : "失败。\r\n原因是：" + FailedInfo + "。\r\n");
                using (FileStream fs = new FileStream(logPath, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(msg);
                    }
                }
                Console.WriteLine("日志记录成功。");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("日志记录失败。\n错误信息：" + ex.Message);
                return false;
            }
        }
    }
}

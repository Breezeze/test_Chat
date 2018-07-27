using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessor
{
    public static class AnalysisCode
    {
        /// <summary>
        /// 解析命令行
        /// </summary>
        /// <param name="cmd">指令关键词</param>
        /// <param name="parameter">参数</param>
        /// <returns></returns>
        public static string AnalysisUserInput(string cmd, string parameter)
        {
            try
            {
                #region 初始版本

                //switch (cmd)
                //{
                //    case "say":
                //        //发送字符串给指定好友
                //        Console.WriteLine("已将消息“{0}”发送给对方！", msg);
                //        break;
                //    case "file":
                //        if (File.Exists(msg))
                //        {
                //            //发送文件
                //            Console.WriteLine("已将路径为“{0}”的文件发送给对方！", msg);
                //        }
                //        else
                //        {
                //            Console.WriteLine("请检查该文件（“{0}”）是否存在！", msg);
                //        }
                //        break;
                //    case "music":
                //        Console.WriteLine("已将名为“{0}”的歌曲推荐给对方！", msg);
                //        break;
                //    case "acticle":
                //        Console.WriteLine("已将名为“{0}”的文章推荐给对方！", msg);
                //        break;
                //    default:
                //        Console.WriteLine("未知命令“{0}”！", str);
                //        break;
                //}

                #endregion

                if (LoadCommandSet.GetProcessClass(cmd) == null)
                {
                    throw new Exception("未知命令“" + cmd + "”！");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            try
            {
                return LoadCommandSet.GetProcessClass(cmd).Do(parameter);
            }
            catch (Exception ex)
            {
                return "出现未知错误！请重试！";
            }

        }

        /// <summary>
        /// 日志存储
        /// </summary>
        private static void LogRecord()
        {

        }
    }
}

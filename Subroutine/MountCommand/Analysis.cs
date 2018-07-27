using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountCommand
{
    public static class Analysis
    {
        /// <summary>
        /// 解析命令行
        /// </summary>
        /// <param name="userInput"></param>
        public static string AnalysisCode(string userInput)
        {
            try
            {
                int colonIndex = userInput.IndexOf(':');
                string cmd = userInput.Substring(0, colonIndex);
                string parameter = userInput.Substring(colonIndex + 1);

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

                return LoadCommand.GetProcessClass(cmd.ToLower()).Do(parameter);

            }
            catch (Exception)
            {
                return "未知命令“" + userInput + "”！";
            }
        }
    }
}

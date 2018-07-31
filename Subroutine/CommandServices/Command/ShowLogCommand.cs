using System;
using System.IO;
using System.Text;

namespace CommandServices.Command
{
    public class ShowLogCommand : BaseCommand
    {
        /// <summary>
        /// 日志文件路径
        /// </summary>
        private string logFilePath = "ChatLog.txt";

        public override string Behavior { get { return "查看日志"; } }
        public override string CommandName { get { return "showlog"; } }
        protected override bool IsStorable { get { return false; } }
        protected override int MaxParaNum { get { return 0; } }
        protected override int MinParaNum { get { return 0; } }

        protected override void Prepare(string[] parameters)
        {
            base.parameters = parameters;
            IsValidPara();
            IsFileExists();
        }

        private void IsFileExists()
        {
            if (!File.Exists(logFilePath))
            {
                throw new Exception("日志文件丢失，无法查看！");
            }
        }

        protected override void Do()
        {
            StreamReader sr = new StreamReader(logFilePath, Encoding.UTF8);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("日志结束！");
        }
    }
}


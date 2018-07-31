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

        public override string CommandName => "showlog";
        public override string Behavior => "查看日志";
        protected override bool IsStorable => false;
        protected override int MaxParaNum => 0;
        protected override int MinParaNum => 0;

        protected override void Prepare(string[] parameters)
        {
            this.parameters = parameters;
            IsValidPara();
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


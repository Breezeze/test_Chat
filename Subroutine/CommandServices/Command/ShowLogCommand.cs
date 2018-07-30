using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices.Command
{
    public class ShowLogCommand : ICommand
    {
        public string Behavior { get { return "查看日志"; } }
        public string CommandName { get { return "showlog"; } }
        public bool IsStore { get { return false; } }

        public void Do(params string[] parameter)
        {
            string path = "ChatLog.txt";

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line.ToString());
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("日志结束！");
            }
            else
            {
                Console.WriteLine("日志文件丢失，无法查看！");
            }
        }
    }
}

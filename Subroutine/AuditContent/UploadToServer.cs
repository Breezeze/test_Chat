using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditContent
{
    public class UploadToServer : IUpload
    {
        public void Upload(string userInput)
        {
            Console.WriteLine("已发送至服务器。");
        }
    }
}

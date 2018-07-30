using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditContent
{
    public class UploadToAdmin : IUpload
    {
        public void Upload(string userInput)
        {
            Console.WriteLine("已发送给管理员。");
        }
    }
}

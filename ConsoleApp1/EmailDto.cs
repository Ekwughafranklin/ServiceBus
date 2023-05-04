using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailDto
    {
        public string Receiver { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }
        public string Subject { get; set; }
    }
}

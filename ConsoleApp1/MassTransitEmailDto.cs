using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MassTransitEmailDto
    {

        public string messageId { get; set; }
        public string conversationId { get; set; }
        public string sourceAddress { get; set; }
        public string destinationAddress { get; set; }
        public string[] messageType { get; set; }
        public EmailDto message { get; set; }
        public DateTime sentTime { get; set; }
        public Headers headers { get; set; }
        public Host host { get; set; }

        public class Headers
        {
            public string MTActivityId { get; set; }
        }

        public class Host
        {
            public string machineName { get; set; }
            public string processName { get; set; }
            public int processId { get; set; }
            public string assembly { get; set; }
            public string assemblyVersion { get; set; }
            public string frameworkVersion { get; set; }
            public string massTransitVersion { get; set; }
            public string operatingSystemVersion { get; set; }
        }

    }
}

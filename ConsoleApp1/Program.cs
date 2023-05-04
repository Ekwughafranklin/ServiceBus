using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static async Task Main(string[] args)
        {
            string ServiceBusConnectionString = "";

            try
            {
                var productRating = new MassTransitEmailDto
                {
                    message = new EmailDto
                    {
                        Receiver = "ekwugha.franklin@gmail.com",
                        Body = "testing",
                        Subject = "testing",

                    }
                };
                for (int i = 0; i < 8; i++)
                {
                    var message = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(productRating)));
                    var topicClient = new TopicClient(ServiceBusConnectionString, "");
                    await topicClient.SendAsync(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

using CoreDataHandling;
using MqHandling;
using Shared;
using System;

namespace MqReceiver
{
    class Program
    {


        static void Main(string[] args)
        {
            MqHandler<XData> mq = new MqHandler<XData>("SycoMq");
            SR_Core.ServiceCoreClient client = new SR_Core.ServiceCoreClient();
            //CoreDataHandler dh = new CoreDataHandler();

            

            while (true)
            {
                var temp = mq.Receive();
                client.AddDataToRepo(temp.Target, temp);
                //dh.AddDataToRepo(temp.Target, temp);
                Console.WriteLine("Added: " + temp.ToString());

            }
        }
    }
}

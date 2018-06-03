using MqHandling;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Messaging; //add reference to Messaging
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;  //add reference to Serialization
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Test
{

    class Program
    {

        static void Main(string[] args)
        {
            SR.ServiceRepoClient client = new SR.ServiceRepoClient();
            SR_Core.ServiceCoreClient client1 = new SR_Core.ServiceCoreClient();

            foreach (var item in client.QueryAvailableResources())
            {
                Console.WriteLine("Data: "+item.ToString());
            }

            Console.WriteLine();
            

            foreach (var item in client1.GetAvailableRepos())
            {
                Console.WriteLine("Data: " + item.ToString());
            }


            MqHandler<XData> mq = new MqHandler<XData>("SycoMq");

            mq.

            Console.ReadLine();
        }
    }
}

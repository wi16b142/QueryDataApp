using ServiceDefinitionCore;
using System;
using System.ServiceModel;

namespace ServiceCoreHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceCore));
            host.Open();
            Console.WriteLine("Core Service started.");
            Console.ReadLine();
        }
    }
}

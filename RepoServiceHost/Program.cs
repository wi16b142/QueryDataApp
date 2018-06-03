using RepoServiceDefinition;
using System;
using System.ServiceModel;

namespace RepoServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceRepo));
            host.Open();
            Console.WriteLine("Repo host started.");
            Console.ReadLine();
        }
    }
}

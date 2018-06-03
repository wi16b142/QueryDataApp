using CoreDataHandling;
using Shared;
using System.Collections.Generic;

namespace ServiceDefinitionCore
{
    public class ServiceCore : IServiceCore
    {
        CoreDataHandler dh = new CoreDataHandler();

        public bool AddDataToRepo(string repo, XData data)
        {
            return dh.AddDataToRepo(repo, data);
        }

        public List<string> GetAvailableRepos()
        {
            return dh.GetAvailableRepos();
        }

        public List<string> GetAvailableTypes()
        {
            return dh.GetAvailableTypes();
        }

        public List<XData> GetDataFromRepo(string repo)
        {
            return dh.GetDataFromRepo(repo);
        }
    }
}

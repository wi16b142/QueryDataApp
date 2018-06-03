using DataHandling;
using Shared;
using System.Collections.Generic;

namespace RepoServiceDefinition
{
    public class ServiceRepo : IServiceRepo
    {
        DataHandler dh = new DataHandler();

        public bool AddDataToRepo(string repo, XData data)
        {
            return dh.AddDataToRepo(repo, data);
        }

        public List<XData> QueryAllDataFromRepo(string repo)
        {
            return dh.QueryAllDataFromRepo(repo);
        }

        public List<string> QueryAvailableResources()
        {
            return dh.QueryAvailableResources();
        }

        public string[] QueryAvailableTypes()
        {
            return dh.QueryAvailableTypes();
        }
    }
}

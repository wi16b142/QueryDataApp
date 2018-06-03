using CoreDataHandling.SR_Repo;
using Shared;
using System.Collections.Generic;

namespace CoreDataHandling
{

    public class CoreDataHandler
    {
        ServiceRepoClient client = new ServiceRepoClient();

        public bool AddDataToRepo(string repo, XData data)
        {
            return client.AddDataToRepo(repo, data);
        }

        public List<string> GetAvailableRepos()
        {
            return client.QueryAvailableResources();
        }

        public List<string> GetAvailableTypes()
        {
            return client.QueryAvailableTypes();
        }

        public List<XData> GetDataFromRepo(string repo)
        {
            return client.QueryAllDataFromRepo(repo);
        }
    }
}

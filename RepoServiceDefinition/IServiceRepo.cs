using Shared;
using System.Collections.Generic;
using System.ServiceModel;

namespace RepoServiceDefinition
{
    [ServiceContract]
    public interface IServiceRepo
    {
        [OperationContract]
        List<string> QueryAvailableResources();
        [OperationContract]
        string[] QueryAvailableTypes();
        [OperationContract]
        List<XData> QueryAllDataFromRepo(string repo);
        [OperationContract]
        bool AddDataToRepo(string repo, XData data);
    }
}

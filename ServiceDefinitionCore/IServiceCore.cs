using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceDefinitionCore
{
    [ServiceContract]
    public interface IServiceCore
    {
        [OperationContract]
        bool AddDataToRepo(string repo, XData data);
        [OperationContract]
        List<string> GetAvailableRepos();
        [OperationContract]
        List<string> GetAvailableTypes();
        [OperationContract]
        List<XData> GetDataFromRepo(string repo);
    }
}

using Shared;
using System;
using System.Collections.Generic;

namespace DataHandling
{

    public class DataHandler
    {
        static Random rand = new Random();
        static string[] types = { "internal" ,"external" };

        static Dictionary<string, List<XData>> Repositories = new Dictionary<string, List<XData>>()
        {
            {"RepoA", new List<XData>(DemoData(rand.Next(1, 20))) },
            {"RepoB", new List<XData>(DemoData(rand.Next(1, 20))) },
            {"RepoC", new List<XData>(DemoData(rand.Next(1, 20))) }
        };

        public List<XData> QueryAllDataFromRepo(string repo)
        {
            List<XData> temp = new List<XData>();

            //return specified list
            foreach (var item in Repositories)
            {
                if (item.Key.Equals(repo)) return item.Value;
            }

            //default return aggregated List
            foreach (var item in Repositories)
            {
                temp.AddRange(item.Value);
            }return temp;
        }

        public List<string> QueryAvailableResources()
        {
            List<string> repos = new List<string>();
            foreach (var item in Repositories)
            {
                repos.Add(item.Key);
            }return repos;
        }

        public string[] QueryAvailableTypes()
        {
            return types;
        }

        public bool AddDataToRepo(string repo, XData data)
        {
            try
            {
                foreach (var item in Repositories)
                {
                    if (item.Key.Equals(repo)) item.Value.Add(data);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static List<XData> DemoData(int size)
        {
            List<XData> demo = new List<XData>();

            for (int i = 0; i < size; i++)
            {
                demo.Add(new XData(
                    "Name"+rand.Next(),
                    types[rand.Next(0,2)],
                    rand.Next(900,6001),
                    rand.NextDouble()>=0.5,
                    Guid.NewGuid()
                ));
            }
            return demo;
        }
    }
}

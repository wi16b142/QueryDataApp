using System;
using System.Runtime.Serialization; //add reference to Serialization

namespace Shared
{
    [DataContract]
    public class XData
    {
        public XData()
        {
        }

        public XData(string name, string type, decimal salary, bool ownskey, Guid id, string target)
        {
            Name = name;
            Type = type;
            Salary = salary;
            Ownskey = ownskey;
            Id = id;
            Target = target;
        }

        public XData(string name, string type, decimal salary, bool ownskey, Guid id)
        {
            Name = name;
            Type = type;
            Salary = salary;
            Ownskey = ownskey;
            Id = id;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public Decimal Salary { get; set; }
        [DataMember]
        public bool Ownskey { get; set; }
        [DataMember]
        public Guid Id { get; set; }
        public string Target { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", Id, Name, Type, Salary, Ownskey);
        }
    }
}

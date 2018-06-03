﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.SR {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="XData", Namespace="http://schemas.datacontract.org/2004/07/Shared")]
    [System.SerializableAttribute()]
    public partial class XData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OwnskeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ownskey {
            get {
                return this.OwnskeyField;
            }
            set {
                if ((this.OwnskeyField.Equals(value) != true)) {
                    this.OwnskeyField = value;
                    this.RaisePropertyChanged("Ownskey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR.IServiceRepo")]
    public interface IServiceRepo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAvailableResources", ReplyAction="http://tempuri.org/IServiceRepo/QueryAvailableResourcesResponse")]
        string[] QueryAvailableResources();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAvailableResources", ReplyAction="http://tempuri.org/IServiceRepo/QueryAvailableResourcesResponse")]
        System.Threading.Tasks.Task<string[]> QueryAvailableResourcesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAvailableTypes", ReplyAction="http://tempuri.org/IServiceRepo/QueryAvailableTypesResponse")]
        string[] QueryAvailableTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAvailableTypes", ReplyAction="http://tempuri.org/IServiceRepo/QueryAvailableTypesResponse")]
        System.Threading.Tasks.Task<string[]> QueryAvailableTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAllDataFromRepo", ReplyAction="http://tempuri.org/IServiceRepo/QueryAllDataFromRepoResponse")]
        Test.SR.XData[] QueryAllDataFromRepo(string repo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/QueryAllDataFromRepo", ReplyAction="http://tempuri.org/IServiceRepo/QueryAllDataFromRepoResponse")]
        System.Threading.Tasks.Task<Test.SR.XData[]> QueryAllDataFromRepoAsync(string repo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/AddDataToRepo", ReplyAction="http://tempuri.org/IServiceRepo/AddDataToRepoResponse")]
        bool AddDataToRepo(string repo, Test.SR.XData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepo/AddDataToRepo", ReplyAction="http://tempuri.org/IServiceRepo/AddDataToRepoResponse")]
        System.Threading.Tasks.Task<bool> AddDataToRepoAsync(string repo, Test.SR.XData data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceRepoChannel : Test.SR.IServiceRepo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceRepoClient : System.ServiceModel.ClientBase<Test.SR.IServiceRepo>, Test.SR.IServiceRepo {
        
        public ServiceRepoClient() {
        }
        
        public ServiceRepoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceRepoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] QueryAvailableResources() {
            return base.Channel.QueryAvailableResources();
        }
        
        public System.Threading.Tasks.Task<string[]> QueryAvailableResourcesAsync() {
            return base.Channel.QueryAvailableResourcesAsync();
        }
        
        public string[] QueryAvailableTypes() {
            return base.Channel.QueryAvailableTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> QueryAvailableTypesAsync() {
            return base.Channel.QueryAvailableTypesAsync();
        }
        
        public Test.SR.XData[] QueryAllDataFromRepo(string repo) {
            return base.Channel.QueryAllDataFromRepo(repo);
        }
        
        public System.Threading.Tasks.Task<Test.SR.XData[]> QueryAllDataFromRepoAsync(string repo) {
            return base.Channel.QueryAllDataFromRepoAsync(repo);
        }
        
        public bool AddDataToRepo(string repo, Test.SR.XData data) {
            return base.Channel.AddDataToRepo(repo, data);
        }
        
        public System.Threading.Tasks.Task<bool> AddDataToRepoAsync(string repo, Test.SR.XData data) {
            return base.Channel.AddDataToRepoAsync(repo, data);
        }
    }
}
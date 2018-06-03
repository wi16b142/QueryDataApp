﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.SR_Core {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Core.IServiceCore")]
    public interface IServiceCore {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/AddDataToRepo", ReplyAction="http://tempuri.org/IServiceCore/AddDataToRepoResponse")]
        bool AddDataToRepo(string repo, Test.SR_Core.XData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/AddDataToRepo", ReplyAction="http://tempuri.org/IServiceCore/AddDataToRepoResponse")]
        System.Threading.Tasks.Task<bool> AddDataToRepoAsync(string repo, Test.SR_Core.XData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetAvailableRepos", ReplyAction="http://tempuri.org/IServiceCore/GetAvailableReposResponse")]
        string[] GetAvailableRepos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetAvailableRepos", ReplyAction="http://tempuri.org/IServiceCore/GetAvailableReposResponse")]
        System.Threading.Tasks.Task<string[]> GetAvailableReposAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetAvailableTypes", ReplyAction="http://tempuri.org/IServiceCore/GetAvailableTypesResponse")]
        string[] GetAvailableTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetAvailableTypes", ReplyAction="http://tempuri.org/IServiceCore/GetAvailableTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetAvailableTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetDataFromRepo", ReplyAction="http://tempuri.org/IServiceCore/GetDataFromRepoResponse")]
        Test.SR_Core.XData[] GetDataFromRepo(string repo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCore/GetDataFromRepo", ReplyAction="http://tempuri.org/IServiceCore/GetDataFromRepoResponse")]
        System.Threading.Tasks.Task<Test.SR_Core.XData[]> GetDataFromRepoAsync(string repo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCoreChannel : Test.SR_Core.IServiceCore, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCoreClient : System.ServiceModel.ClientBase<Test.SR_Core.IServiceCore>, Test.SR_Core.IServiceCore {
        
        public ServiceCoreClient() {
        }
        
        public ServiceCoreClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCoreClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCoreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCoreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddDataToRepo(string repo, Test.SR_Core.XData data) {
            return base.Channel.AddDataToRepo(repo, data);
        }
        
        public System.Threading.Tasks.Task<bool> AddDataToRepoAsync(string repo, Test.SR_Core.XData data) {
            return base.Channel.AddDataToRepoAsync(repo, data);
        }
        
        public string[] GetAvailableRepos() {
            return base.Channel.GetAvailableRepos();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAvailableReposAsync() {
            return base.Channel.GetAvailableReposAsync();
        }
        
        public string[] GetAvailableTypes() {
            return base.Channel.GetAvailableTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAvailableTypesAsync() {
            return base.Channel.GetAvailableTypesAsync();
        }
        
        public Test.SR_Core.XData[] GetDataFromRepo(string repo) {
            return base.Channel.GetDataFromRepo(repo);
        }
        
        public System.Threading.Tasks.Task<Test.SR_Core.XData[]> GetDataFromRepoAsync(string repo) {
            return base.Channel.GetDataFromRepoAsync(repo);
        }
    }
}

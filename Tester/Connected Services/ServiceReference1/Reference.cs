﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tester.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    using System.ServiceModel.Web;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DemoRequest", Namespace="http://schemas.datacontract.org/2004/07/Backend")]
    [System.SerializableAttribute()]
    public partial class DemoRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FooField;
        
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
        public string Bar {
            get {
                return this.BarField;
            }
            set {
                if ((object.ReferenceEquals(this.BarField, value) != true)) {
                    this.BarField = value;
                    this.RaisePropertyChanged("Bar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Foo {
            get {
                return this.FooField;
            }
            set {
                if ((object.ReferenceEquals(this.FooField, value) != true)) {
                    this.FooField = value;
                    this.RaisePropertyChanged("Foo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DemoResponse", Namespace="http://schemas.datacontract.org/2004/07/Backend")]
    [System.SerializableAttribute()]
    public partial class DemoResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BazField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuuxField;
        
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
        public string Baz {
            get {
                return this.BazField;
            }
            set {
                if ((object.ReferenceEquals(this.BazField, value) != true)) {
                    this.BazField = value;
                    this.RaisePropertyChanged("Baz");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quux {
            get {
                return this.QuuxField;
            }
            set {
                if ((object.ReferenceEquals(this.QuuxField, value) != true)) {
                    this.QuuxField = value;
                    this.RaisePropertyChanged("Quux");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/DoTheThing", ReplyAction="http://tempuri.org/IDemoService/DoTheThingResponse")]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Tester.ServiceReference1.DemoResponse DoTheThing(Tester.ServiceReference1.DemoRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : Tester.ServiceReference1.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<Tester.ServiceReference1.IDemoService>, Tester.ServiceReference1.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tester.ServiceReference1.DemoResponse DoTheThing(Tester.ServiceReference1.DemoRequest request) {
            return base.Channel.DoTheThing(request);
        }
    }
}
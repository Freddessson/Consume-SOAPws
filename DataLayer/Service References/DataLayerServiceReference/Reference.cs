﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.DataLayerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://grupp10/")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string pnrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string pnr {
            get {
                return this.pnrField;
            }
            set {
                if ((object.ReferenceEquals(this.pnrField, value) != true)) {
                    this.pnrField = value;
                    this.RaisePropertyChanged("pnr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://grupp10/", ConfigurationName="DataLayerServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/HelloWorld", ReplyAction="*")]
        DataLayer.DataLayerServiceReference.HelloWorldResponse HelloWorld(DataLayer.DataLayerServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.HelloWorldResponse> HelloWorldAsync(DataLayer.DataLayerServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name filename from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetContent", ReplyAction="*")]
        DataLayer.DataLayerServiceReference.GetContentResponse GetContent(DataLayer.DataLayerServiceReference.GetContentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetContent", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.GetContentResponse> GetContentAsync(DataLayer.DataLayerServiceReference.GetContentRequest request);
        
        // CODEGEN: Generating message contract since element name FindAllCustomersResult from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/FindAllCustomers", ReplyAction="*")]
        DataLayer.DataLayerServiceReference.FindAllCustomersResponse FindAllCustomers(DataLayer.DataLayerServiceReference.FindAllCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/FindAllCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.FindAllCustomersResponse> FindAllCustomersAsync(DataLayer.DataLayerServiceReference.FindAllCustomersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DataLayer.DataLayerServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DataLayer.DataLayerServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContent", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.GetContentRequestBody Body;
        
        public GetContentRequest() {
        }
        
        public GetContentRequest(DataLayer.DataLayerServiceReference.GetContentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class GetContentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string filename;
        
        public GetContentRequestBody() {
        }
        
        public GetContentRequestBody(string filename) {
            this.filename = filename;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContentResponse", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.GetContentResponseBody Body;
        
        public GetContentResponse() {
        }
        
        public GetContentResponse(DataLayer.DataLayerServiceReference.GetContentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class GetContentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetContentResult;
        
        public GetContentResponseBody() {
        }
        
        public GetContentResponseBody(string GetContentResult) {
            this.GetContentResult = GetContentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindAllCustomersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindAllCustomers", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.FindAllCustomersRequestBody Body;
        
        public FindAllCustomersRequest() {
        }
        
        public FindAllCustomersRequest(DataLayer.DataLayerServiceReference.FindAllCustomersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class FindAllCustomersRequestBody {
        
        public FindAllCustomersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindAllCustomersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindAllCustomersResponse", Namespace="http://grupp10/", Order=0)]
        public DataLayer.DataLayerServiceReference.FindAllCustomersResponseBody Body;
        
        public FindAllCustomersResponse() {
        }
        
        public FindAllCustomersResponse(DataLayer.DataLayerServiceReference.FindAllCustomersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class FindAllCustomersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DataLayer.DataLayerServiceReference.Customer[] FindAllCustomersResult;
        
        public FindAllCustomersResponseBody() {
        }
        
        public FindAllCustomersResponseBody(DataLayer.DataLayerServiceReference.Customer[] FindAllCustomersResult) {
            this.FindAllCustomersResult = FindAllCustomersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : DataLayer.DataLayerServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<DataLayer.DataLayerServiceReference.WebServiceSoap>, DataLayer.DataLayerServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.DataLayerServiceReference.HelloWorldResponse DataLayer.DataLayerServiceReference.WebServiceSoap.HelloWorld(DataLayer.DataLayerServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DataLayer.DataLayerServiceReference.HelloWorldRequest inValue = new DataLayer.DataLayerServiceReference.HelloWorldRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.HelloWorldRequestBody();
            DataLayer.DataLayerServiceReference.HelloWorldResponse retVal = ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.HelloWorldResponse> DataLayer.DataLayerServiceReference.WebServiceSoap.HelloWorldAsync(DataLayer.DataLayerServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.HelloWorldResponse> HelloWorldAsync() {
            DataLayer.DataLayerServiceReference.HelloWorldRequest inValue = new DataLayer.DataLayerServiceReference.HelloWorldRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.HelloWorldRequestBody();
            return ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.DataLayerServiceReference.GetContentResponse DataLayer.DataLayerServiceReference.WebServiceSoap.GetContent(DataLayer.DataLayerServiceReference.GetContentRequest request) {
            return base.Channel.GetContent(request);
        }
        
        public string GetContent(string filename) {
            DataLayer.DataLayerServiceReference.GetContentRequest inValue = new DataLayer.DataLayerServiceReference.GetContentRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.GetContentRequestBody();
            inValue.Body.filename = filename;
            DataLayer.DataLayerServiceReference.GetContentResponse retVal = ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).GetContent(inValue);
            return retVal.Body.GetContentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.GetContentResponse> DataLayer.DataLayerServiceReference.WebServiceSoap.GetContentAsync(DataLayer.DataLayerServiceReference.GetContentRequest request) {
            return base.Channel.GetContentAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.GetContentResponse> GetContentAsync(string filename) {
            DataLayer.DataLayerServiceReference.GetContentRequest inValue = new DataLayer.DataLayerServiceReference.GetContentRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.GetContentRequestBody();
            inValue.Body.filename = filename;
            return ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).GetContentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.DataLayerServiceReference.FindAllCustomersResponse DataLayer.DataLayerServiceReference.WebServiceSoap.FindAllCustomers(DataLayer.DataLayerServiceReference.FindAllCustomersRequest request) {
            return base.Channel.FindAllCustomers(request);
        }
        
        public DataLayer.DataLayerServiceReference.Customer[] FindAllCustomers() {
            DataLayer.DataLayerServiceReference.FindAllCustomersRequest inValue = new DataLayer.DataLayerServiceReference.FindAllCustomersRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.FindAllCustomersRequestBody();
            DataLayer.DataLayerServiceReference.FindAllCustomersResponse retVal = ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).FindAllCustomers(inValue);
            return retVal.Body.FindAllCustomersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.FindAllCustomersResponse> DataLayer.DataLayerServiceReference.WebServiceSoap.FindAllCustomersAsync(DataLayer.DataLayerServiceReference.FindAllCustomersRequest request) {
            return base.Channel.FindAllCustomersAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.DataLayerServiceReference.FindAllCustomersResponse> FindAllCustomersAsync() {
            DataLayer.DataLayerServiceReference.FindAllCustomersRequest inValue = new DataLayer.DataLayerServiceReference.FindAllCustomersRequest();
            inValue.Body = new DataLayer.DataLayerServiceReference.FindAllCustomersRequestBody();
            return ((DataLayer.DataLayerServiceReference.WebServiceSoap)(this)).FindAllCustomersAsync(inValue);
        }
    }
}

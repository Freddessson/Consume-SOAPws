﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.ServiceReference123 {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://grupp10/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://grupp10/", ConfigurationName="ServiceReference123.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/HelloWorld", ReplyAction="*")]
        DataLayer.ServiceReference123.HelloWorldResponse HelloWorld(DataLayer.ServiceReference123.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.HelloWorldResponse> HelloWorldAsync(DataLayer.ServiceReference123.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name filename from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetContent", ReplyAction="*")]
        DataLayer.ServiceReference123.GetContentResponse GetContent(DataLayer.ServiceReference123.GetContentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetContent", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetContentResponse> GetContentAsync(DataLayer.ServiceReference123.GetContentRequest request);
        
        // CODEGEN: Generating message contract since element name FindAllCustomersResult from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/FindAllCustomers", ReplyAction="*")]
        DataLayer.ServiceReference123.FindAllCustomersResponse FindAllCustomers(DataLayer.ServiceReference123.FindAllCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/FindAllCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.FindAllCustomersResponse> FindAllCustomersAsync(DataLayer.ServiceReference123.FindAllCustomersRequest request);
        
        // CODEGEN: Generating message contract since element name GetCronusEmployeesResult from namespace http://grupp10/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetCronusEmployees", ReplyAction="*")]
        DataLayer.ServiceReference123.GetCronusEmployeesResponse GetCronusEmployees(DataLayer.ServiceReference123.GetCronusEmployeesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp10/GetCronusEmployees", ReplyAction="*")]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetCronusEmployeesResponse> GetCronusEmployeesAsync(DataLayer.ServiceReference123.GetCronusEmployeesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://grupp10/", Order=0)]
        public DataLayer.ServiceReference123.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DataLayer.ServiceReference123.HelloWorldRequestBody Body) {
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
        public DataLayer.ServiceReference123.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DataLayer.ServiceReference123.HelloWorldResponseBody Body) {
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
        public DataLayer.ServiceReference123.GetContentRequestBody Body;
        
        public GetContentRequest() {
        }
        
        public GetContentRequest(DataLayer.ServiceReference123.GetContentRequestBody Body) {
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
        public DataLayer.ServiceReference123.GetContentResponseBody Body;
        
        public GetContentResponse() {
        }
        
        public GetContentResponse(DataLayer.ServiceReference123.GetContentResponseBody Body) {
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
        public DataLayer.ServiceReference123.FindAllCustomersRequestBody Body;
        
        public FindAllCustomersRequest() {
        }
        
        public FindAllCustomersRequest(DataLayer.ServiceReference123.FindAllCustomersRequestBody Body) {
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
        public DataLayer.ServiceReference123.FindAllCustomersResponseBody Body;
        
        public FindAllCustomersResponse() {
        }
        
        public FindAllCustomersResponse(DataLayer.ServiceReference123.FindAllCustomersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class FindAllCustomersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DataLayer.ServiceReference123.Customer[] FindAllCustomersResult;
        
        public FindAllCustomersResponseBody() {
        }
        
        public FindAllCustomersResponseBody(DataLayer.ServiceReference123.Customer[] FindAllCustomersResult) {
            this.FindAllCustomersResult = FindAllCustomersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCronusEmployeesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCronusEmployees", Namespace="http://grupp10/", Order=0)]
        public DataLayer.ServiceReference123.GetCronusEmployeesRequestBody Body;
        
        public GetCronusEmployeesRequest() {
        }
        
        public GetCronusEmployeesRequest(DataLayer.ServiceReference123.GetCronusEmployeesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCronusEmployeesRequestBody {
        
        public GetCronusEmployeesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCronusEmployeesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCronusEmployeesResponse", Namespace="http://grupp10/", Order=0)]
        public DataLayer.ServiceReference123.GetCronusEmployeesResponseBody Body;
        
        public GetCronusEmployeesResponse() {
        }
        
        public GetCronusEmployeesResponse(DataLayer.ServiceReference123.GetCronusEmployeesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://grupp10/")]
    public partial class GetCronusEmployeesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DataLayer.ServiceReference123.ArrayOfString GetCronusEmployeesResult;
        
        public GetCronusEmployeesResponseBody() {
        }
        
        public GetCronusEmployeesResponseBody(DataLayer.ServiceReference123.ArrayOfString GetCronusEmployeesResult) {
            this.GetCronusEmployeesResult = GetCronusEmployeesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : DataLayer.ServiceReference123.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<DataLayer.ServiceReference123.WebServiceSoap>, DataLayer.ServiceReference123.WebServiceSoap {
        
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
        DataLayer.ServiceReference123.HelloWorldResponse DataLayer.ServiceReference123.WebServiceSoap.HelloWorld(DataLayer.ServiceReference123.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DataLayer.ServiceReference123.HelloWorldRequest inValue = new DataLayer.ServiceReference123.HelloWorldRequest();
            inValue.Body = new DataLayer.ServiceReference123.HelloWorldRequestBody();
            DataLayer.ServiceReference123.HelloWorldResponse retVal = ((DataLayer.ServiceReference123.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.HelloWorldResponse> DataLayer.ServiceReference123.WebServiceSoap.HelloWorldAsync(DataLayer.ServiceReference123.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.ServiceReference123.HelloWorldResponse> HelloWorldAsync() {
            DataLayer.ServiceReference123.HelloWorldRequest inValue = new DataLayer.ServiceReference123.HelloWorldRequest();
            inValue.Body = new DataLayer.ServiceReference123.HelloWorldRequestBody();
            return ((DataLayer.ServiceReference123.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.ServiceReference123.GetContentResponse DataLayer.ServiceReference123.WebServiceSoap.GetContent(DataLayer.ServiceReference123.GetContentRequest request) {
            return base.Channel.GetContent(request);
        }
        
        public string GetContent(string filename) {
            DataLayer.ServiceReference123.GetContentRequest inValue = new DataLayer.ServiceReference123.GetContentRequest();
            inValue.Body = new DataLayer.ServiceReference123.GetContentRequestBody();
            inValue.Body.filename = filename;
            DataLayer.ServiceReference123.GetContentResponse retVal = ((DataLayer.ServiceReference123.WebServiceSoap)(this)).GetContent(inValue);
            return retVal.Body.GetContentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetContentResponse> DataLayer.ServiceReference123.WebServiceSoap.GetContentAsync(DataLayer.ServiceReference123.GetContentRequest request) {
            return base.Channel.GetContentAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetContentResponse> GetContentAsync(string filename) {
            DataLayer.ServiceReference123.GetContentRequest inValue = new DataLayer.ServiceReference123.GetContentRequest();
            inValue.Body = new DataLayer.ServiceReference123.GetContentRequestBody();
            inValue.Body.filename = filename;
            return ((DataLayer.ServiceReference123.WebServiceSoap)(this)).GetContentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.ServiceReference123.FindAllCustomersResponse DataLayer.ServiceReference123.WebServiceSoap.FindAllCustomers(DataLayer.ServiceReference123.FindAllCustomersRequest request) {
            return base.Channel.FindAllCustomers(request);
        }
        
        public DataLayer.ServiceReference123.Customer[] FindAllCustomers() {
            DataLayer.ServiceReference123.FindAllCustomersRequest inValue = new DataLayer.ServiceReference123.FindAllCustomersRequest();
            inValue.Body = new DataLayer.ServiceReference123.FindAllCustomersRequestBody();
            DataLayer.ServiceReference123.FindAllCustomersResponse retVal = ((DataLayer.ServiceReference123.WebServiceSoap)(this)).FindAllCustomers(inValue);
            return retVal.Body.FindAllCustomersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.FindAllCustomersResponse> DataLayer.ServiceReference123.WebServiceSoap.FindAllCustomersAsync(DataLayer.ServiceReference123.FindAllCustomersRequest request) {
            return base.Channel.FindAllCustomersAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.ServiceReference123.FindAllCustomersResponse> FindAllCustomersAsync() {
            DataLayer.ServiceReference123.FindAllCustomersRequest inValue = new DataLayer.ServiceReference123.FindAllCustomersRequest();
            inValue.Body = new DataLayer.ServiceReference123.FindAllCustomersRequestBody();
            return ((DataLayer.ServiceReference123.WebServiceSoap)(this)).FindAllCustomersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataLayer.ServiceReference123.GetCronusEmployeesResponse DataLayer.ServiceReference123.WebServiceSoap.GetCronusEmployees(DataLayer.ServiceReference123.GetCronusEmployeesRequest request) {
            return base.Channel.GetCronusEmployees(request);
        }
        
        public DataLayer.ServiceReference123.ArrayOfString GetCronusEmployees() {
            DataLayer.ServiceReference123.GetCronusEmployeesRequest inValue = new DataLayer.ServiceReference123.GetCronusEmployeesRequest();
            inValue.Body = new DataLayer.ServiceReference123.GetCronusEmployeesRequestBody();
            DataLayer.ServiceReference123.GetCronusEmployeesResponse retVal = ((DataLayer.ServiceReference123.WebServiceSoap)(this)).GetCronusEmployees(inValue);
            return retVal.Body.GetCronusEmployeesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetCronusEmployeesResponse> DataLayer.ServiceReference123.WebServiceSoap.GetCronusEmployeesAsync(DataLayer.ServiceReference123.GetCronusEmployeesRequest request) {
            return base.Channel.GetCronusEmployeesAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataLayer.ServiceReference123.GetCronusEmployeesResponse> GetCronusEmployeesAsync() {
            DataLayer.ServiceReference123.GetCronusEmployeesRequest inValue = new DataLayer.ServiceReference123.GetCronusEmployeesRequest();
            inValue.Body = new DataLayer.ServiceReference123.GetCronusEmployeesRequestBody();
            return ((DataLayer.ServiceReference123.WebServiceSoap)(this)).GetCronusEmployeesAsync(inValue);
        }
    }
}

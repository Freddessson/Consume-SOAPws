﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://grupp10/")]
public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetContentOperationCompleted;
    
    private System.Threading.SendOrPostCallback FindAllCustomersOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetCronusEmployeesOperationCompleted;
    
    /// <remarks/>
    public WebService() {
        this.Url = "http://localhost:64761/WebService.asmx";
    }
    
    /// <remarks/>
    public event HelloWorldCompletedEventHandler HelloWorldCompleted;
    
    /// <remarks/>
    public event GetContentCompletedEventHandler GetContentCompleted;
    
    /// <remarks/>
    public event FindAllCustomersCompletedEventHandler FindAllCustomersCompleted;
    
    /// <remarks/>
    public event GetCronusEmployeesCompletedEventHandler GetCronusEmployeesCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp10/HelloWorld", RequestNamespace="http://grupp10/", ResponseNamespace="http://grupp10/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string HelloWorld() {
        object[] results = this.Invoke("HelloWorld", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string EndHelloWorld(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void HelloWorldAsync() {
        this.HelloWorldAsync(null);
    }
    
    /// <remarks/>
    public void HelloWorldAsync(object userState) {
        if ((this.HelloWorldOperationCompleted == null)) {
            this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
        }
        this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
    }
    
    private void OnHelloWorldOperationCompleted(object arg) {
        if ((this.HelloWorldCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp10/GetContent", RequestNamespace="http://grupp10/", ResponseNamespace="http://grupp10/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string GetContent(string filename) {
        object[] results = this.Invoke("GetContent", new object[] {
                    filename});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetContent(string filename, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetContent", new object[] {
                    filename}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndGetContent(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void GetContentAsync(string filename) {
        this.GetContentAsync(filename, null);
    }
    
    /// <remarks/>
    public void GetContentAsync(string filename, object userState) {
        if ((this.GetContentOperationCompleted == null)) {
            this.GetContentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetContentOperationCompleted);
        }
        this.InvokeAsync("GetContent", new object[] {
                    filename}, this.GetContentOperationCompleted, userState);
    }
    
    private void OnGetContentOperationCompleted(object arg) {
        if ((this.GetContentCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetContentCompleted(this, new GetContentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp10/FindAllCustomers", RequestNamespace="http://grupp10/", ResponseNamespace="http://grupp10/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public Customer[] FindAllCustomers() {
        object[] results = this.Invoke("FindAllCustomers", new object[0]);
        return ((Customer[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginFindAllCustomers(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("FindAllCustomers", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public Customer[] EndFindAllCustomers(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Customer[])(results[0]));
    }
    
    /// <remarks/>
    public void FindAllCustomersAsync() {
        this.FindAllCustomersAsync(null);
    }
    
    /// <remarks/>
    public void FindAllCustomersAsync(object userState) {
        if ((this.FindAllCustomersOperationCompleted == null)) {
            this.FindAllCustomersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindAllCustomersOperationCompleted);
        }
        this.InvokeAsync("FindAllCustomers", new object[0], this.FindAllCustomersOperationCompleted, userState);
    }
    
    private void OnFindAllCustomersOperationCompleted(object arg) {
        if ((this.FindAllCustomersCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.FindAllCustomersCompleted(this, new FindAllCustomersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp10/GetCronusEmployees", RequestNamespace="http://grupp10/", ResponseNamespace="http://grupp10/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfString")]
    [return: System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
    public string[][] GetCronusEmployees() {
        object[] results = this.Invoke("GetCronusEmployees", new object[0]);
        return ((string[][])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetCronusEmployees(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetCronusEmployees", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string[][] EndGetCronusEmployees(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string[][])(results[0]));
    }
    
    /// <remarks/>
    public void GetCronusEmployeesAsync() {
        this.GetCronusEmployeesAsync(null);
    }
    
    /// <remarks/>
    public void GetCronusEmployeesAsync(object userState) {
        if ((this.GetCronusEmployeesOperationCompleted == null)) {
            this.GetCronusEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCronusEmployeesOperationCompleted);
        }
        this.InvokeAsync("GetCronusEmployees", new object[0], this.GetCronusEmployeesOperationCompleted, userState);
    }
    
    private void OnGetCronusEmployeesOperationCompleted(object arg) {
        if ((this.GetCronusEmployeesCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetCronusEmployeesCompleted(this, new GetCronusEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp10/")]
public partial class Customer {
    
    private string nameField;
    
    private string pnrField;
    
    private string emailField;
    
    private string phoneField;
    
    private string addressField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string pnr {
        get {
            return this.pnrField;
        }
        set {
            this.pnrField = value;
        }
    }
    
    /// <remarks/>
    public string email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public string address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void GetContentCompletedEventHandler(object sender, GetContentCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetContentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetContentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void FindAllCustomersCompletedEventHandler(object sender, FindAllCustomersCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FindAllCustomersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal FindAllCustomersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public Customer[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Customer[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void GetCronusEmployeesCompletedEventHandler(object sender, GetCronusEmployeesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetCronusEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetCronusEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string[][] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string[][])(this.results[0]));
        }
    }
}

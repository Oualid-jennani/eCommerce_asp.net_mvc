//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebServices.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCurrentDayRevenueOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRevenueByPeriodOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetBestSellingProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTopFiveClientsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::WebServices.Properties.Settings.Default.WebServices_localhost_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCurrentDayRevenueCompletedEventHandler GetCurrentDayRevenueCompleted;
        
        /// <remarks/>
        public event GetRevenueByPeriodCompletedEventHandler GetRevenueByPeriodCompleted;
        
        /// <remarks/>
        public event GetBestSellingProductCompletedEventHandler GetBestSellingProductCompleted;
        
        /// <remarks/>
        public event GetTopFiveClientsCompletedEventHandler GetTopFiveClientsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCurrentDayRevenue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public float GetCurrentDayRevenue() {
            object[] results = this.Invoke("GetCurrentDayRevenue", new object[0]);
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentDayRevenueAsync() {
            this.GetCurrentDayRevenueAsync(null);
        }
        
        /// <remarks/>
        public void GetCurrentDayRevenueAsync(object userState) {
            if ((this.GetCurrentDayRevenueOperationCompleted == null)) {
                this.GetCurrentDayRevenueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentDayRevenueOperationCompleted);
            }
            this.InvokeAsync("GetCurrentDayRevenue", new object[0], this.GetCurrentDayRevenueOperationCompleted, userState);
        }
        
        private void OnGetCurrentDayRevenueOperationCompleted(object arg) {
            if ((this.GetCurrentDayRevenueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentDayRevenueCompleted(this, new GetCurrentDayRevenueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRevenueByPeriod", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public float GetRevenueByPeriod(System.DateTime startDate, System.DateTime endDate) {
            object[] results = this.Invoke("GetRevenueByPeriod", new object[] {
                        startDate,
                        endDate});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void GetRevenueByPeriodAsync(System.DateTime startDate, System.DateTime endDate) {
            this.GetRevenueByPeriodAsync(startDate, endDate, null);
        }
        
        /// <remarks/>
        public void GetRevenueByPeriodAsync(System.DateTime startDate, System.DateTime endDate, object userState) {
            if ((this.GetRevenueByPeriodOperationCompleted == null)) {
                this.GetRevenueByPeriodOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRevenueByPeriodOperationCompleted);
            }
            this.InvokeAsync("GetRevenueByPeriod", new object[] {
                        startDate,
                        endDate}, this.GetRevenueByPeriodOperationCompleted, userState);
        }
        
        private void OnGetRevenueByPeriodOperationCompleted(object arg) {
            if ((this.GetRevenueByPeriodCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRevenueByPeriodCompleted(this, new GetRevenueByPeriodCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBestSellingProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBestSellingProduct() {
            object[] results = this.Invoke("GetBestSellingProduct", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetBestSellingProductAsync() {
            this.GetBestSellingProductAsync(null);
        }
        
        /// <remarks/>
        public void GetBestSellingProductAsync(object userState) {
            if ((this.GetBestSellingProductOperationCompleted == null)) {
                this.GetBestSellingProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBestSellingProductOperationCompleted);
            }
            this.InvokeAsync("GetBestSellingProduct", new object[0], this.GetBestSellingProductOperationCompleted, userState);
        }
        
        private void OnGetBestSellingProductOperationCompleted(object arg) {
            if ((this.GetBestSellingProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBestSellingProductCompleted(this, new GetBestSellingProductCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTopFiveClients", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TopClient[] GetTopFiveClients() {
            object[] results = this.Invoke("GetTopFiveClients", new object[0]);
            return ((TopClient[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTopFiveClientsAsync() {
            this.GetTopFiveClientsAsync(null);
        }
        
        /// <remarks/>
        public void GetTopFiveClientsAsync(object userState) {
            if ((this.GetTopFiveClientsOperationCompleted == null)) {
                this.GetTopFiveClientsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTopFiveClientsOperationCompleted);
            }
            this.InvokeAsync("GetTopFiveClients", new object[0], this.GetTopFiveClientsOperationCompleted, userState);
        }
        
        private void OnGetTopFiveClientsOperationCompleted(object arg) {
            if ((this.GetTopFiveClientsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTopFiveClientsCompleted(this, new GetTopFiveClientsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TopClient {
        
        private int idField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string phoneField;
        
        private string emailField;
        
        private string adressField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
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
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string adress {
            get {
                return this.adressField;
            }
            set {
                this.adressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetCurrentDayRevenueCompletedEventHandler(object sender, GetCurrentDayRevenueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentDayRevenueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentDayRevenueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetRevenueByPeriodCompletedEventHandler(object sender, GetRevenueByPeriodCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRevenueByPeriodCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRevenueByPeriodCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetBestSellingProductCompletedEventHandler(object sender, GetBestSellingProductCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBestSellingProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBestSellingProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetTopFiveClientsCompletedEventHandler(object sender, GetTopFiveClientsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTopFiveClientsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTopFiveClientsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TopClient[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TopClient[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.SecureWebServiceSoap")]
    public interface SecureWebServiceSoap {
        
        // CODEGEN: Generating message contract since message ValidUserRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        TestConsole.ServiceReference1.ValidUserResponse ValidUser(TestConsole.ServiceReference1.ValidUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidUser", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConsole.ServiceReference1.ValidUserResponse> ValidUserAsync(TestConsole.ServiceReference1.ValidUserRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Authentication : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
                this.RaisePropertyChanged("User");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidUserRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public TestConsole.ServiceReference1.Authentication Authentication;
        
        public ValidUserRequest() {
        }
        
        public ValidUserRequest(TestConsole.ServiceReference1.Authentication Authentication) {
            this.Authentication = Authentication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string ValidUserResult;
        
        public ValidUserResponse() {
        }
        
        public ValidUserResponse(string ValidUserResult) {
            this.ValidUserResult = ValidUserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SecureWebServiceSoapChannel : TestConsole.ServiceReference1.SecureWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecureWebServiceSoapClient : System.ServiceModel.ClientBase<TestConsole.ServiceReference1.SecureWebServiceSoap>, TestConsole.ServiceReference1.SecureWebServiceSoap {
        
        public SecureWebServiceSoapClient() {
        }
        
        public SecureWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecureWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecureWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecureWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConsole.ServiceReference1.ValidUserResponse TestConsole.ServiceReference1.SecureWebServiceSoap.ValidUser(TestConsole.ServiceReference1.ValidUserRequest request) {
            return base.Channel.ValidUser(request);
        }
        
        public string ValidUser(TestConsole.ServiceReference1.Authentication Authentication) {
            TestConsole.ServiceReference1.ValidUserRequest inValue = new TestConsole.ServiceReference1.ValidUserRequest();
            inValue.Authentication = Authentication;
            TestConsole.ServiceReference1.ValidUserResponse retVal = ((TestConsole.ServiceReference1.SecureWebServiceSoap)(this)).ValidUser(inValue);
            return retVal.ValidUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestConsole.ServiceReference1.ValidUserResponse> TestConsole.ServiceReference1.SecureWebServiceSoap.ValidUserAsync(TestConsole.ServiceReference1.ValidUserRequest request) {
            return base.Channel.ValidUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestConsole.ServiceReference1.ValidUserResponse> ValidUserAsync(TestConsole.ServiceReference1.Authentication Authentication) {
            TestConsole.ServiceReference1.ValidUserRequest inValue = new TestConsole.ServiceReference1.ValidUserRequest();
            inValue.Authentication = Authentication;
            return ((TestConsole.ServiceReference1.SecureWebServiceSoap)(this)).ValidUserAsync(inValue);
        }
    }
}
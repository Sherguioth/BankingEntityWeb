﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteBankSWNet.ProductRegistrationWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webServices/", ConfigurationName="ProductRegistrationWebService.ProductRegistrationWebService")]
    public interface ProductRegistrationWebService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/insertProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/insertProductRegistrationRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse insertProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/insertProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/insertProductRegistrationRespons" +
            "e")]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse> insertProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/findProductRegistrationRequest", ReplyAction="http://webServices/ProductRegistrationWebService/findProductRegistrationResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse findProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/findProductRegistrationRequest", ReplyAction="http://webServices/ProductRegistrationWebService/findProductRegistrationResponse")]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse> findProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/updateProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/updateProductRegistrationRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse updateProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/updateProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/updateProductRegistrationRespons" +
            "e")]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse> updateProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/deleteProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/deleteProductRegistrationRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse deleteProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/deleteProductRegistrationRequest" +
            "", ReplyAction="http://webServices/ProductRegistrationWebService/deleteProductRegistrationRespons" +
            "e")]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse> deleteProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/listAllProductRegistrationsServi" +
            "ceRequest", ReplyAction="http://webServices/ProductRegistrationWebService/listAllProductRegistrationsServi" +
            "ceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse listAllProductRegistrationsService(ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webServices/ProductRegistrationWebService/listAllProductRegistrationsServi" +
            "ceRequest", ReplyAction="http://webServices/ProductRegistrationWebService/listAllProductRegistrationsServi" +
            "ceResponse")]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse> listAllProductRegistrationsServiceAsync(ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webServices/")]
    public partial class productRegistration : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double balanceField;
        
        private int clientIdField;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private int productCodeField;
        
        private int productNumberField;
        
        private System.DateTime registratioDateField;
        
        private bool registratioDateFieldSpecified;
        
        private bool stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
                this.RaisePropertyChanged("balance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int clientId {
            get {
                return this.clientIdField;
            }
            set {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
                this.RaisePropertyChanged("expirationDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
                this.RaisePropertyChanged("expirationDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int productCode {
            get {
                return this.productCodeField;
            }
            set {
                this.productCodeField = value;
                this.RaisePropertyChanged("productCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int productNumber {
            get {
                return this.productNumberField;
            }
            set {
                this.productNumberField = value;
                this.RaisePropertyChanged("productNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=5)]
        public System.DateTime registratioDate {
            get {
                return this.registratioDateField;
            }
            set {
                this.registratioDateField = value;
                this.RaisePropertyChanged("registratioDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool registratioDateSpecified {
            get {
                return this.registratioDateFieldSpecified;
            }
            set {
                this.registratioDateFieldSpecified = value;
                this.RaisePropertyChanged("registratioDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("state");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertProductRegistration", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class insertProductRegistrationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg0;
        
        public insertProductRegistrationRequest() {
        }
        
        public insertProductRegistrationRequest(ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertProductRegistrationResponse", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class insertProductRegistrationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public insertProductRegistrationResponse() {
        }
        
        public insertProductRegistrationResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findProductRegistration", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class findProductRegistrationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        public findProductRegistrationRequest() {
        }
        
        public findProductRegistrationRequest(int arg0, int arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findProductRegistrationResponse", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class findProductRegistrationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration @return;
        
        public findProductRegistrationResponse() {
        }
        
        public findProductRegistrationResponse(ClienteBankSWNet.ProductRegistrationWebService.productRegistration @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateProductRegistration", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class updateProductRegistrationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg2;
        
        public updateProductRegistrationRequest() {
        }
        
        public updateProductRegistrationRequest(int arg0, int arg1, ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg2) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateProductRegistrationResponse", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class updateProductRegistrationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public updateProductRegistrationResponse() {
        }
        
        public updateProductRegistrationResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteProductRegistration", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class deleteProductRegistrationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        public deleteProductRegistrationRequest() {
        }
        
        public deleteProductRegistrationRequest(int arg0, int arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteProductRegistrationResponse", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class deleteProductRegistrationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public deleteProductRegistrationResponse() {
        }
        
        public deleteProductRegistrationResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listAllProductRegistrationsService", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class listAllProductRegistrationsServiceRequest {
        
        public listAllProductRegistrationsServiceRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listAllProductRegistrationsServiceResponse", WrapperNamespace="http://webServices/", IsWrapped=true)]
    public partial class listAllProductRegistrationsServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration[] @return;
        
        public listAllProductRegistrationsServiceResponse() {
        }
        
        public listAllProductRegistrationsServiceResponse(ClienteBankSWNet.ProductRegistrationWebService.productRegistration[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductRegistrationWebServiceChannel : ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductRegistrationWebServiceClient : System.ServiceModel.ClientBase<ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService>, ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService {
        
        public ProductRegistrationWebServiceClient() {
        }
        
        public ProductRegistrationWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductRegistrationWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRegistrationWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRegistrationWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.insertProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest request) {
            return base.Channel.insertProductRegistration(request);
        }
        
        public bool insertProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg0) {
            ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest();
            inValue.arg0 = arg0;
            ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse retVal = ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).insertProductRegistration(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse> ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.insertProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest request) {
            return base.Channel.insertProductRegistrationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationResponse> insertProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg0) {
            ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.insertProductRegistrationRequest();
            inValue.arg0 = arg0;
            return ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).insertProductRegistrationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.findProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest request) {
            return base.Channel.findProductRegistration(request);
        }
        
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration findProductRegistration(int arg0, int arg1) {
            ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse retVal = ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).findProductRegistration(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse> ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.findProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest request) {
            return base.Channel.findProductRegistrationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationResponse> findProductRegistrationAsync(int arg0, int arg1) {
            ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.findProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).findProductRegistrationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.updateProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest request) {
            return base.Channel.updateProductRegistration(request);
        }
        
        public bool updateProductRegistration(int arg0, int arg1, ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg2) {
            ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse retVal = ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).updateProductRegistration(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse> ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.updateProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest request) {
            return base.Channel.updateProductRegistrationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationResponse> updateProductRegistrationAsync(int arg0, int arg1, ClienteBankSWNet.ProductRegistrationWebService.productRegistration arg2) {
            ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.updateProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            return ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).updateProductRegistrationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.deleteProductRegistration(ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest request) {
            return base.Channel.deleteProductRegistration(request);
        }
        
        public bool deleteProductRegistration(int arg0, int arg1) {
            ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse retVal = ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).deleteProductRegistration(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse> ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.deleteProductRegistrationAsync(ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest request) {
            return base.Channel.deleteProductRegistrationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationResponse> deleteProductRegistrationAsync(int arg0, int arg1) {
            ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.deleteProductRegistrationRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).deleteProductRegistrationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.listAllProductRegistrationsService(ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest request) {
            return base.Channel.listAllProductRegistrationsService(request);
        }
        
        public ClienteBankSWNet.ProductRegistrationWebService.productRegistration[] listAllProductRegistrationsService() {
            ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest();
            ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse retVal = ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).listAllProductRegistrationsService(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse> ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService.listAllProductRegistrationsServiceAsync(ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest request) {
            return base.Channel.listAllProductRegistrationsServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceResponse> listAllProductRegistrationsServiceAsync() {
            ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest inValue = new ClienteBankSWNet.ProductRegistrationWebService.listAllProductRegistrationsServiceRequest();
            return ((ClienteBankSWNet.ProductRegistrationWebService.ProductRegistrationWebService)(this)).listAllProductRegistrationsServiceAsync(inValue);
        }
    }
}

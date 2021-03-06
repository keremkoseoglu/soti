﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3603.
// 
#pragma warning disable 1591

namespace soti.Sapservice {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'Policy' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    // CODEGEN: The optional WSDL extension element 'EndpointReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/08/addressing' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ZLAW_I6", Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I6 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ZLAW_I_GET_MASTER_DATAOperationCompleted;
        
        private System.Threading.SendOrPostCallback ZLAW_I_SET_DEPARTMENTSOperationCompleted;
        
        private System.Threading.SendOrPostCallback ZLAW_I_SET_DM_USERSOperationCompleted;
        
        private System.Threading.SendOrPostCallback ZLAW_I_SET_DOCUMENT_TYPESOperationCompleted;
        
        private System.Threading.SendOrPostCallback ZLAW_I_SET_MASTER_DATA_OKOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ZLAW_I6() {
            this.Url = "http://APSOSIRIS.pekinandpekin.law:8004/sap/bc/srt/rfc/sap/zlaw_i6/500/zlaw_i6/zl" +
                "aw_i6";
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
        public event ZLAW_I_GET_MASTER_DATACompletedEventHandler ZLAW_I_GET_MASTER_DATACompleted;
        
        /// <remarks/>
        public event ZLAW_I_SET_DEPARTMENTSCompletedEventHandler ZLAW_I_SET_DEPARTMENTSCompleted;
        
        /// <remarks/>
        public event ZLAW_I_SET_DM_USERSCompletedEventHandler ZLAW_I_SET_DM_USERSCompleted;
        
        /// <remarks/>
        public event ZLAW_I_SET_DOCUMENT_TYPESCompletedEventHandler ZLAW_I_SET_DOCUMENT_TYPESCompleted;
        
        /// <remarks/>
        public event ZLAW_I_SET_MASTER_DATA_OKCompletedEventHandler ZLAW_I_SET_MASTER_DATA_OKCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZLAW_I_GET_MASTER_DATAResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZLAW_I_GET_MASTER_DATAResponse ZLAW_I_GET_MASTER_DATA([System.Xml.Serialization.XmlElementAttribute("ZLAW_I_GET_MASTER_DATA", Namespace="urn:sap-com:document:sap:rfc:functions")] ZLAW_I_GET_MASTER_DATA ZLAW_I_GET_MASTER_DATA1) {
            object[] results = this.Invoke("ZLAW_I_GET_MASTER_DATA", new object[] {
                        ZLAW_I_GET_MASTER_DATA1});
            return ((ZLAW_I_GET_MASTER_DATAResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ZLAW_I_GET_MASTER_DATAAsync(ZLAW_I_GET_MASTER_DATA ZLAW_I_GET_MASTER_DATA1) {
            this.ZLAW_I_GET_MASTER_DATAAsync(ZLAW_I_GET_MASTER_DATA1, null);
        }
        
        /// <remarks/>
        public void ZLAW_I_GET_MASTER_DATAAsync(ZLAW_I_GET_MASTER_DATA ZLAW_I_GET_MASTER_DATA1, object userState) {
            if ((this.ZLAW_I_GET_MASTER_DATAOperationCompleted == null)) {
                this.ZLAW_I_GET_MASTER_DATAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZLAW_I_GET_MASTER_DATAOperationCompleted);
            }
            this.InvokeAsync("ZLAW_I_GET_MASTER_DATA", new object[] {
                        ZLAW_I_GET_MASTER_DATA1}, this.ZLAW_I_GET_MASTER_DATAOperationCompleted, userState);
        }
        
        private void OnZLAW_I_GET_MASTER_DATAOperationCompleted(object arg) {
            if ((this.ZLAW_I_GET_MASTER_DATACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZLAW_I_GET_MASTER_DATACompleted(this, new ZLAW_I_GET_MASTER_DATACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DEPARTMENTSResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZLAW_I_SET_DEPARTMENTSResponse ZLAW_I_SET_DEPARTMENTS([System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DEPARTMENTS", Namespace="urn:sap-com:document:sap:rfc:functions")] ZLAW_I_SET_DEPARTMENTS ZLAW_I_SET_DEPARTMENTS1) {
            object[] results = this.Invoke("ZLAW_I_SET_DEPARTMENTS", new object[] {
                        ZLAW_I_SET_DEPARTMENTS1});
            return ((ZLAW_I_SET_DEPARTMENTSResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DEPARTMENTSAsync(ZLAW_I_SET_DEPARTMENTS ZLAW_I_SET_DEPARTMENTS1) {
            this.ZLAW_I_SET_DEPARTMENTSAsync(ZLAW_I_SET_DEPARTMENTS1, null);
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DEPARTMENTSAsync(ZLAW_I_SET_DEPARTMENTS ZLAW_I_SET_DEPARTMENTS1, object userState) {
            if ((this.ZLAW_I_SET_DEPARTMENTSOperationCompleted == null)) {
                this.ZLAW_I_SET_DEPARTMENTSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZLAW_I_SET_DEPARTMENTSOperationCompleted);
            }
            this.InvokeAsync("ZLAW_I_SET_DEPARTMENTS", new object[] {
                        ZLAW_I_SET_DEPARTMENTS1}, this.ZLAW_I_SET_DEPARTMENTSOperationCompleted, userState);
        }
        
        private void OnZLAW_I_SET_DEPARTMENTSOperationCompleted(object arg) {
            if ((this.ZLAW_I_SET_DEPARTMENTSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZLAW_I_SET_DEPARTMENTSCompleted(this, new ZLAW_I_SET_DEPARTMENTSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DM_USERSResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZLAW_I_SET_DM_USERSResponse ZLAW_I_SET_DM_USERS([System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DM_USERS", Namespace="urn:sap-com:document:sap:rfc:functions")] ZLAW_I_SET_DM_USERS ZLAW_I_SET_DM_USERS1) {
            object[] results = this.Invoke("ZLAW_I_SET_DM_USERS", new object[] {
                        ZLAW_I_SET_DM_USERS1});
            return ((ZLAW_I_SET_DM_USERSResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DM_USERSAsync(ZLAW_I_SET_DM_USERS ZLAW_I_SET_DM_USERS1) {
            this.ZLAW_I_SET_DM_USERSAsync(ZLAW_I_SET_DM_USERS1, null);
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DM_USERSAsync(ZLAW_I_SET_DM_USERS ZLAW_I_SET_DM_USERS1, object userState) {
            if ((this.ZLAW_I_SET_DM_USERSOperationCompleted == null)) {
                this.ZLAW_I_SET_DM_USERSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZLAW_I_SET_DM_USERSOperationCompleted);
            }
            this.InvokeAsync("ZLAW_I_SET_DM_USERS", new object[] {
                        ZLAW_I_SET_DM_USERS1}, this.ZLAW_I_SET_DM_USERSOperationCompleted, userState);
        }
        
        private void OnZLAW_I_SET_DM_USERSOperationCompleted(object arg) {
            if ((this.ZLAW_I_SET_DM_USERSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZLAW_I_SET_DM_USERSCompleted(this, new ZLAW_I_SET_DM_USERSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DOCUMENT_TYPESResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZLAW_I_SET_DOCUMENT_TYPESResponse ZLAW_I_SET_DOCUMENT_TYPES([System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_DOCUMENT_TYPES", Namespace="urn:sap-com:document:sap:rfc:functions")] ZLAW_I_SET_DOCUMENT_TYPES ZLAW_I_SET_DOCUMENT_TYPES1) {
            object[] results = this.Invoke("ZLAW_I_SET_DOCUMENT_TYPES", new object[] {
                        ZLAW_I_SET_DOCUMENT_TYPES1});
            return ((ZLAW_I_SET_DOCUMENT_TYPESResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DOCUMENT_TYPESAsync(ZLAW_I_SET_DOCUMENT_TYPES ZLAW_I_SET_DOCUMENT_TYPES1) {
            this.ZLAW_I_SET_DOCUMENT_TYPESAsync(ZLAW_I_SET_DOCUMENT_TYPES1, null);
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_DOCUMENT_TYPESAsync(ZLAW_I_SET_DOCUMENT_TYPES ZLAW_I_SET_DOCUMENT_TYPES1, object userState) {
            if ((this.ZLAW_I_SET_DOCUMENT_TYPESOperationCompleted == null)) {
                this.ZLAW_I_SET_DOCUMENT_TYPESOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZLAW_I_SET_DOCUMENT_TYPESOperationCompleted);
            }
            this.InvokeAsync("ZLAW_I_SET_DOCUMENT_TYPES", new object[] {
                        ZLAW_I_SET_DOCUMENT_TYPES1}, this.ZLAW_I_SET_DOCUMENT_TYPESOperationCompleted, userState);
        }
        
        private void OnZLAW_I_SET_DOCUMENT_TYPESOperationCompleted(object arg) {
            if ((this.ZLAW_I_SET_DOCUMENT_TYPESCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZLAW_I_SET_DOCUMENT_TYPESCompleted(this, new ZLAW_I_SET_DOCUMENT_TYPESCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_MASTER_DATA_OKResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZLAW_I_SET_MASTER_DATA_OKResponse ZLAW_I_SET_MASTER_DATA_OK([System.Xml.Serialization.XmlElementAttribute("ZLAW_I_SET_MASTER_DATA_OK", Namespace="urn:sap-com:document:sap:rfc:functions")] ZLAW_I_SET_MASTER_DATA_OK ZLAW_I_SET_MASTER_DATA_OK1) {
            object[] results = this.Invoke("ZLAW_I_SET_MASTER_DATA_OK", new object[] {
                        ZLAW_I_SET_MASTER_DATA_OK1});
            return ((ZLAW_I_SET_MASTER_DATA_OKResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_MASTER_DATA_OKAsync(ZLAW_I_SET_MASTER_DATA_OK ZLAW_I_SET_MASTER_DATA_OK1) {
            this.ZLAW_I_SET_MASTER_DATA_OKAsync(ZLAW_I_SET_MASTER_DATA_OK1, null);
        }
        
        /// <remarks/>
        public void ZLAW_I_SET_MASTER_DATA_OKAsync(ZLAW_I_SET_MASTER_DATA_OK ZLAW_I_SET_MASTER_DATA_OK1, object userState) {
            if ((this.ZLAW_I_SET_MASTER_DATA_OKOperationCompleted == null)) {
                this.ZLAW_I_SET_MASTER_DATA_OKOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZLAW_I_SET_MASTER_DATA_OKOperationCompleted);
            }
            this.InvokeAsync("ZLAW_I_SET_MASTER_DATA_OK", new object[] {
                        ZLAW_I_SET_MASTER_DATA_OK1}, this.ZLAW_I_SET_MASTER_DATA_OKOperationCompleted, userState);
        }
        
        private void OnZLAW_I_SET_MASTER_DATA_OKOperationCompleted(object arg) {
            if ((this.ZLAW_I_SET_MASTER_DATA_OKCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZLAW_I_SET_MASTER_DATA_OKCompleted(this, new ZLAW_I_SET_MASTER_DATA_OKCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_GET_MASTER_DATA {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_S_DOCTYPE {
        
        private string tYPEIField;
        
        private string dESCRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TYPEI {
            get {
                return this.tYPEIField;
            }
            set {
                this.tYPEIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DESCR {
            get {
                return this.dESCRField;
            }
            set {
                this.dESCRField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_DM_04 {
        
        private string mANDTField;
        
        private string uSRIDField;
        
        private string fNAMEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MANDT {
            get {
                return this.mANDTField;
            }
            set {
                this.mANDTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USRID {
            get {
                return this.uSRIDField;
            }
            set {
                this.uSRIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FNAME {
            get {
                return this.fNAMEField;
            }
            set {
                this.fNAMEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_S_DEPARTMENT {
        
        private string eDPRTField;
        
        private string dPRTXField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EDPRT {
            get {
                return this.eDPRTField;
            }
            set {
                this.eDPRTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DPRTX {
            get {
                return this.dPRTXField;
            }
            set {
                this.dPRTXField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_S_MATTERI {
        
        private string mATNOField;
        
        private string mATNMField;
        
        private string kUNNRField;
        
        private string aCTIOField;
        
        private string nAME1Field;
        
        private string oNAM1Field;
        
        private string oNAM2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MATNO {
            get {
                return this.mATNOField;
            }
            set {
                this.mATNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MATNM {
            get {
                return this.mATNMField;
            }
            set {
                this.mATNMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KUNNR {
            get {
                return this.kUNNRField;
            }
            set {
                this.kUNNRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACTIO {
            get {
                return this.aCTIOField;
            }
            set {
                this.aCTIOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME1 {
            get {
                return this.nAME1Field;
            }
            set {
                this.nAME1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ONAM1 {
            get {
                return this.oNAM1Field;
            }
            set {
                this.oNAM1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ONAM2 {
            get {
                return this.oNAM2Field;
            }
            set {
                this.oNAM2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_S_CUSTOMERI {
        
        private string kUNNRField;
        
        private string nAME1Field;
        
        private string oNAM1Field;
        
        private string oNAM2Field;
        
        private string aCTIOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KUNNR {
            get {
                return this.kUNNRField;
            }
            set {
                this.kUNNRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME1 {
            get {
                return this.nAME1Field;
            }
            set {
                this.nAME1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ONAM1 {
            get {
                return this.oNAM1Field;
            }
            set {
                this.oNAM1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ONAM2 {
            get {
                return this.oNAM2Field;
            }
            set {
                this.oNAM2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACTIO {
            get {
                return this.aCTIOField;
            }
            set {
                this.aCTIOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_GET_MASTER_DATAResponse {
        
        private ZLAW_S_CUSTOMERI[] e_CUSTOMERSField;
        
        private string e_ERDATField;
        
        private string e_ERZETField;
        
        private ZLAW_S_MATTERI[] e_MATTERSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZLAW_S_CUSTOMERI[] E_CUSTOMERS {
            get {
                return this.e_CUSTOMERSField;
            }
            set {
                this.e_CUSTOMERSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string E_ERDAT {
            get {
                return this.e_ERDATField;
            }
            set {
                this.e_ERDATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string E_ERZET {
            get {
                return this.e_ERZETField;
            }
            set {
                this.e_ERZETField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZLAW_S_MATTERI[] E_MATTERS {
            get {
                return this.e_MATTERSField;
            }
            set {
                this.e_MATTERSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DEPARTMENTS {
        
        private ZLAW_S_DEPARTMENT[] i_DEPARTMENTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZLAW_S_DEPARTMENT[] I_DEPARTMENTS {
            get {
                return this.i_DEPARTMENTSField;
            }
            set {
                this.i_DEPARTMENTSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DEPARTMENTSResponse {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DM_USERS {
        
        private ZLAW_DM_04[] i_USERField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZLAW_DM_04[] I_USER {
            get {
                return this.i_USERField;
            }
            set {
                this.i_USERField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DM_USERSResponse {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DOCUMENT_TYPES {
        
        private ZLAW_S_DOCTYPE[] i_DOCTYPESField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZLAW_S_DOCTYPE[] I_DOCTYPES {
            get {
                return this.i_DOCTYPESField;
            }
            set {
                this.i_DOCTYPESField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_DOCUMENT_TYPESResponse {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_MASTER_DATA_OK {
        
        private string i_ERDATField;
        
        private string i_ERZETField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string I_ERDAT {
            get {
                return this.i_ERDATField;
            }
            set {
                this.i_ERDATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string I_ERZET {
            get {
                return this.i_ERZETField;
            }
            set {
                this.i_ERZETField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZLAW_I_SET_MASTER_DATA_OKResponse {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ZLAW_I_GET_MASTER_DATACompletedEventHandler(object sender, ZLAW_I_GET_MASTER_DATACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZLAW_I_GET_MASTER_DATACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZLAW_I_GET_MASTER_DATACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ZLAW_I_GET_MASTER_DATAResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ZLAW_I_GET_MASTER_DATAResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ZLAW_I_SET_DEPARTMENTSCompletedEventHandler(object sender, ZLAW_I_SET_DEPARTMENTSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZLAW_I_SET_DEPARTMENTSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZLAW_I_SET_DEPARTMENTSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ZLAW_I_SET_DEPARTMENTSResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ZLAW_I_SET_DEPARTMENTSResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ZLAW_I_SET_DM_USERSCompletedEventHandler(object sender, ZLAW_I_SET_DM_USERSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZLAW_I_SET_DM_USERSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZLAW_I_SET_DM_USERSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ZLAW_I_SET_DM_USERSResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ZLAW_I_SET_DM_USERSResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ZLAW_I_SET_DOCUMENT_TYPESCompletedEventHandler(object sender, ZLAW_I_SET_DOCUMENT_TYPESCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZLAW_I_SET_DOCUMENT_TYPESCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZLAW_I_SET_DOCUMENT_TYPESCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ZLAW_I_SET_DOCUMENT_TYPESResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ZLAW_I_SET_DOCUMENT_TYPESResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ZLAW_I_SET_MASTER_DATA_OKCompletedEventHandler(object sender, ZLAW_I_SET_MASTER_DATA_OKCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZLAW_I_SET_MASTER_DATA_OKCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZLAW_I_SET_MASTER_DATA_OKCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ZLAW_I_SET_MASTER_DATA_OKResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ZLAW_I_SET_MASTER_DATA_OKResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
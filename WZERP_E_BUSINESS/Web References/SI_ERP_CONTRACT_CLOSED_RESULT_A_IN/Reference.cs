﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.34209 版自动生成。
// 
#pragma warning disable 1591

namespace WZERP_E_BUSINESS.SI_ERP_CONTRACT_CLOSED_RESULT_A_IN {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTBinding", Namespace="urn:sinopec:ec5:wzerp:contract")]
    public partial class SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_ERP_CONTRACT_CLOSED_RESULT_A_IN_SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService;
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
        public event SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTCompletedEventHandler SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void SI_EC5_CONTRACT_CLOSED_RESULT_A_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:ec5:wzerp:contract")] DT_EC5_CONTRACT_PAID_RESULT MT_EC5_ERP_CONTRACT_CLOSED_RESULT) {
            this.Invoke("SI_EC5_CONTRACT_CLOSED_RESULT_A_OUT", new object[] {
                        MT_EC5_ERP_CONTRACT_CLOSED_RESULT});
        }
        
        /// <remarks/>
        public void SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTAsync(DT_EC5_CONTRACT_PAID_RESULT MT_EC5_ERP_CONTRACT_CLOSED_RESULT) {
            this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTAsync(MT_EC5_ERP_CONTRACT_CLOSED_RESULT, null);
        }
        
        /// <remarks/>
        public void SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTAsync(DT_EC5_CONTRACT_PAID_RESULT MT_EC5_ERP_CONTRACT_CLOSED_RESULT, object userState) {
            if ((this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted == null)) {
                this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_EC5_CONTRACT_CLOSED_RESULT_A_OUT", new object[] {
                        MT_EC5_ERP_CONTRACT_CLOSED_RESULT}, this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted, userState);
        }
        
        private void OnSI_EC5_CONTRACT_CLOSED_RESULT_A_OUTOperationCompleted(object arg) {
            if ((this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:ec5:wzerp:contract")]
    public partial class DT_EC5_CONTRACT_PAID_RESULT {
        
        private string mSGIDField;
        
        private string sTRSYSNUMBERField;
        
        private string vBELNField;
        
        private string rESULTField;
        
        private string rESTIMEField;
        
        private string rESDESCField;
        
        private DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT[] cONTRACTITEMRESULTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MSGID {
            get {
                return this.mSGIDField;
            }
            set {
                this.mSGIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRSYSNUMBER {
            get {
                return this.sTRSYSNUMBERField;
            }
            set {
                this.sTRSYSNUMBERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VBELN {
            get {
                return this.vBELNField;
            }
            set {
                this.vBELNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESULT {
            get {
                return this.rESULTField;
            }
            set {
                this.rESULTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESTIME {
            get {
                return this.rESTIMEField;
            }
            set {
                this.rESTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESDESC {
            get {
                return this.rESDESCField;
            }
            set {
                this.rESDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONTRACTITEMRESULT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT[] CONTRACTITEMRESULT {
            get {
                return this.cONTRACTITEMRESULTField;
            }
            set {
                this.cONTRACTITEMRESULTField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ec5:wzerp:contract")]
    public partial class DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT {
        
        private string iNVOICEITEMField;
        
        private string rESDESCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVOICEITEM {
            get {
                return this.iNVOICEITEMField;
            }
            set {
                this.iNVOICEITEMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESDESC {
            get {
                return this.rESDESCField;
            }
            set {
                this.rESDESCField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
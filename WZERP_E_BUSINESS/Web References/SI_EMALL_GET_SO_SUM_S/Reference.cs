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

namespace WZERP_E_BUSINESS.SI_EMALL_GET_SO_SUM_S {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_EMALL_GET_SO_SUM_S_OUTBinding", Namespace="urn:sinopec:uncrm:integration")]
    public partial class SI_EMALL_GET_SO_SUM_S_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_EMALL_GET_SO_SUM_S_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_EMALL_GET_SO_SUM_S_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_EMALL_GET_SO_SUM_S_SI_EMALL_GET_SO_SUM_S_OUTService;
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
        public event SI_EMALL_GET_SO_SUM_S_OUTCompletedEventHandler SI_EMALL_GET_SO_SUM_S_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("MT_GET_SO_SUM_RESP", Namespace="urn:sinopec:uncrm:integration")]
        public DT_GET_SO_SUM_RESP SI_EMALL_GET_SO_SUM_S_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:uncrm:integration")] DT_GET_SO_SUM_REQ MT_GET_SO_SUM_REQ) {
            object[] results = this.Invoke("SI_EMALL_GET_SO_SUM_S_OUT", new object[] {
                        MT_GET_SO_SUM_REQ});
            return ((DT_GET_SO_SUM_RESP)(results[0]));
        }
        
        /// <remarks/>
        public void SI_EMALL_GET_SO_SUM_S_OUTAsync(DT_GET_SO_SUM_REQ MT_GET_SO_SUM_REQ) {
            this.SI_EMALL_GET_SO_SUM_S_OUTAsync(MT_GET_SO_SUM_REQ, null);
        }
        
        /// <remarks/>
        public void SI_EMALL_GET_SO_SUM_S_OUTAsync(DT_GET_SO_SUM_REQ MT_GET_SO_SUM_REQ, object userState) {
            if ((this.SI_EMALL_GET_SO_SUM_S_OUTOperationCompleted == null)) {
                this.SI_EMALL_GET_SO_SUM_S_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_EMALL_GET_SO_SUM_S_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_EMALL_GET_SO_SUM_S_OUT", new object[] {
                        MT_GET_SO_SUM_REQ}, this.SI_EMALL_GET_SO_SUM_S_OUTOperationCompleted, userState);
        }
        
        private void OnSI_EMALL_GET_SO_SUM_S_OUTOperationCompleted(object arg) {
            if ((this.SI_EMALL_GET_SO_SUM_S_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_EMALL_GET_SO_SUM_S_OUTCompleted(this, new SI_EMALL_GET_SO_SUM_S_OUTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:uncrm:integration")]
    public partial class DT_GET_SO_SUM_REQ {
        
        private MSG_HEAD iS_MSG_HEADField;
        
        private string iV_TESTRUNField;
        
        private DT_GET_SO_SUM_REQIT_VBELN[] iT_VBELNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MSG_HEAD IS_MSG_HEAD {
            get {
                return this.iS_MSG_HEADField;
            }
            set {
                this.iS_MSG_HEADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IV_TESTRUN {
            get {
                return this.iV_TESTRUNField;
            }
            set {
                this.iV_TESTRUNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IT_VBELN", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_GET_SO_SUM_REQIT_VBELN[] IT_VBELN {
            get {
                return this.iT_VBELNField;
            }
            set {
                this.iT_VBELNField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:uncrm:integration")]
    public partial class MSG_HEAD {
        
        private string mANDTField;
        
        private string gUIDField;
        
        private string pROXY_IDField;
        
        private string sYSTEM_IDField;
        
        private string oPERATORField;
        
        private string sPRASField;
        
        private string iNTERFACE_IDField;
        
        private string sENDERField;
        
        private string rECIVERField;
        
        private string sENDTIMEField;
        
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
        public string GUID {
            get {
                return this.gUIDField;
            }
            set {
                this.gUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROXY_ID {
            get {
                return this.pROXY_IDField;
            }
            set {
                this.pROXY_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SYSTEM_ID {
            get {
                return this.sYSTEM_IDField;
            }
            set {
                this.sYSTEM_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPERATOR {
            get {
                return this.oPERATORField;
            }
            set {
                this.oPERATORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SPRAS {
            get {
                return this.sPRASField;
            }
            set {
                this.sPRASField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTERFACE_ID {
            get {
                return this.iNTERFACE_IDField;
            }
            set {
                this.iNTERFACE_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SENDER {
            get {
                return this.sENDERField;
            }
            set {
                this.sENDERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECIVER {
            get {
                return this.rECIVERField;
            }
            set {
                this.rECIVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SENDTIME {
            get {
                return this.sENDTIMEField;
            }
            set {
                this.sENDTIMEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:uncrm:integration")]
    public partial class DT_BAPIRET2 {
        
        private string tYPEField;
        
        private string idField;
        
        private string nUMBERField;
        
        private string mESSAGEField;
        
        private string lOG_NOField;
        
        private string lOG_MSG_NOField;
        
        private string mESSAGE_V1Field;
        
        private string mESSAGE_V2Field;
        
        private string mESSAGE_V3Field;
        
        private string mESSAGE_V4Field;
        
        private string pARAMETERField;
        
        private string rOWField;
        
        private string fIELDField;
        
        private string sYSTEMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TYPE {
            get {
                return this.tYPEField;
            }
            set {
                this.tYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMBER {
            get {
                return this.nUMBERField;
            }
            set {
                this.nUMBERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE {
            get {
                return this.mESSAGEField;
            }
            set {
                this.mESSAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOG_NO {
            get {
                return this.lOG_NOField;
            }
            set {
                this.lOG_NOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOG_MSG_NO {
            get {
                return this.lOG_MSG_NOField;
            }
            set {
                this.lOG_MSG_NOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V1 {
            get {
                return this.mESSAGE_V1Field;
            }
            set {
                this.mESSAGE_V1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V2 {
            get {
                return this.mESSAGE_V2Field;
            }
            set {
                this.mESSAGE_V2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V3 {
            get {
                return this.mESSAGE_V3Field;
            }
            set {
                this.mESSAGE_V3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V4 {
            get {
                return this.mESSAGE_V4Field;
            }
            set {
                this.mESSAGE_V4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PARAMETER {
            get {
                return this.pARAMETERField;
            }
            set {
                this.pARAMETERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ROW {
            get {
                return this.rOWField;
            }
            set {
                this.rOWField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIELD {
            get {
                return this.fIELDField;
            }
            set {
                this.fIELDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SYSTEM {
            get {
                return this.sYSTEMField;
            }
            set {
                this.sYSTEMField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:uncrm:integration")]
    public partial class DT_GET_SO_SUM_RESP {
        
        private MSG_HEAD eS_MSG_HEADField;
        
        private DT_BAPIRET2[] eT_RETURNField;
        
        private DT_GET_SO_SUM_RESPET_DMBTR[] eT_DMBTRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MSG_HEAD ES_MSG_HEAD {
            get {
                return this.eS_MSG_HEADField;
            }
            set {
                this.eS_MSG_HEADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ET_RETURN", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_BAPIRET2[] ET_RETURN {
            get {
                return this.eT_RETURNField;
            }
            set {
                this.eT_RETURNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ET_DMBTR", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_GET_SO_SUM_RESPET_DMBTR[] ET_DMBTR {
            get {
                return this.eT_DMBTRField;
            }
            set {
                this.eT_DMBTRField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:uncrm:integration")]
    public partial class DT_GET_SO_SUM_RESPET_DMBTR {
        
        private string cRMNOField;
        
        private string vBELNField;
        
        private string aUARTField;
        
        private string dMBTRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CRMNO {
            get {
                return this.cRMNOField;
            }
            set {
                this.cRMNOField = value;
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
        public string AUART {
            get {
                return this.aUARTField;
            }
            set {
                this.aUARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DMBTR {
            get {
                return this.dMBTRField;
            }
            set {
                this.dMBTRField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:uncrm:integration")]
    public partial class DT_GET_SO_SUM_REQIT_VBELN {
        
        private string sIGNField;
        
        private string oPTIONField;
        
        private string lOWField;
        
        private string hIGHField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SIGN {
            get {
                return this.sIGNField;
            }
            set {
                this.sIGNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPTION {
            get {
                return this.oPTIONField;
            }
            set {
                this.oPTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOW {
            get {
                return this.lOWField;
            }
            set {
                this.lOWField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HIGH {
            get {
                return this.hIGHField;
            }
            set {
                this.hIGHField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SI_EMALL_GET_SO_SUM_S_OUTCompletedEventHandler(object sender, SI_EMALL_GET_SO_SUM_S_OUTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SI_EMALL_GET_SO_SUM_S_OUTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SI_EMALL_GET_SO_SUM_S_OUTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DT_GET_SO_SUM_RESP Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DT_GET_SO_SUM_RESP)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
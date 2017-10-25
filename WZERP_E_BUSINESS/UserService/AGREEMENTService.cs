using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Services.Protocols;
using System.Reflection;
using WZERP_E_BUSINESS;



namespace WZERP_E_BUSINESS.UserService
{
    public class AGREEMENTService:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy() 
        {
            return new SI_EC5_ERP_AGREEMENT.SI_EC5_ERP_AGREEMENT_A_OUTService(); 
        }
        private SI_EC5_ERP_AGREEMENT.SI_EC5_ERP_AGREEMENT_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_ERP_AGREEMENT.SI_EC5_ERP_AGREEMENT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务错误:" + ex.Message;
                return false;
            }
            return true;
        }
        //维护项目形象进度
        public string TEST_Agreement(string AgreementStr, string AgreemententStr, string AgreemententmatStr)
        {
            string[] AgreementTmp = AgreementStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] AgreemententTmp = AgreemententStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            string[] AgreemententmatTmp = AgreemententmatStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            SI_EC5_ERP_AGREEMENT.AGREEMENT iv = new SI_EC5_ERP_AGREEMENT.AGREEMENT();

            try
            {
                #region AgreemententmatTmp information
                List<SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENTAgreementMAT> ret_matList = new List<SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENTAgreementMAT>();
                SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENTAgreementMAT matArr = new SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENTAgreementMAT();

                for (var i = 0; i < AgreemententmatTmp.Length; i++)
                {
                    var tmpretArr = AgreemententmatTmp[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                    SetPropertyValue(tmpretArr, matArr);//设置属性值
                    ret_matList.Add(matArr);
                }

                #endregion
   
                #region AgreemententTmp information

                List<SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENT> ret_aentList = new List<SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENT>();
                SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENT aentArr = new SI_EC5_ERP_AGREEMENT.AGREEMENTAgreementENT();
                aentArr.AgreementMAT = ret_matList.ToArray();
                for (var i = 0; i < AgreemententTmp.Length; i++)
                {
                    var tmpretArr = AgreemententTmp[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                    SetPropertyValue(tmpretArr, aentArr);//设置属性值
                    ret_aentList.Add(aentArr);
                }
                #endregion
                
                #region AgreementTmp information               
                SetPropertyValue(AgreementTmp, iv);
                iv.AgreementENT = ret_aentList.ToArray();
                #endregion
            }
            catch (Exception ex)
            {
                return "数据预处理错误:" + ex.Message + ex.Source;
            }
            try
            {
                client.SI_EC5_ERP_AGREEMENT_A_OUT(iv);
                return "S";
            }
            catch (Exception ex)
            {
                return "程序报错!" + ex.Message + ex.Source;
            }
        }
        
    }
}

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
   public  class AGREEMENT_TEXT_RESULTService:ServiceBase
    {

       protected override SoapHttpClientProtocol InstanceProxy()
        {
 	         return new SI_WZERP_AGREEMENT_TEXT_RESULT.SI_WZERP_AGREEMENT_TEXT_RESULT_A_OUTService();
        }
       
        //private SI_WZERP_AGREEMENT_TEXT_RESULT.SI_WZERP_AGREEMENT_TEXT_RESULT_A_OUTService client = null;
       private SI_WZERP_AGREEMENT_TEXT_RESULT.SI_WZERP_AGREEMENT_TEXT_RESULT_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_AGREEMENT_TEXT_RESULT.SI_WZERP_AGREEMENT_TEXT_RESULT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务错误:" + ex.Message;
                return false;
            }
            return true;
        }
        public string TEST_AGREEMENT_TEXT_RESULT(string AgreementTxtStr)
        {
            string[] AgreementTxtTmp = AgreementTxtStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            List<SI_WZERP_AGREEMENT_TEXT_RESULT.DT_EC5_WZERP_AGREEMENT_TEXT_RESULTRESULT> ret_agrList = new List<SI_WZERP_AGREEMENT_TEXT_RESULT.DT_EC5_WZERP_AGREEMENT_TEXT_RESULTRESULT>();
            SI_WZERP_AGREEMENT_TEXT_RESULT.DT_EC5_WZERP_AGREEMENT_TEXT_RESULTRESULT agrArr = new SI_WZERP_AGREEMENT_TEXT_RESULT.DT_EC5_WZERP_AGREEMENT_TEXT_RESULTRESULT();

            for (var i = 0; i < AgreementTxtTmp.Length; i++)
            {
                var tmpretArr = AgreementTxtTmp[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpretArr, agrArr);//设置属性值
                ret_agrList.Add(agrArr);
            }

            try
            {
                try
                {
                    client.SI_WZERP_AGREEMENT_TEXT_RESULT_A_OUT(ret_agrList.ToArray());
                    return "S";
                }
                catch (Exception ex)
                {
                    return "程序报错!" + ex.Message + ex.Source;
                }
            }
            catch (Exception ex)
            {
                return "数据预处理错误:" + ex.Message + ex.Source;
            }
        
        }
    }
}

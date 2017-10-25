using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;
using WZERP_E_BUSINESS;
using WZERP_E_BUSINESS.Model;

namespace WZERP_E_BUSINESS.UserService
{
    public class ZQIF006_RESPService:ServiceBase
    {

        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF006_RESP.SI_WZERP_ZQ_IF006_RESP_A_OUTService();
        }
        private SI_WZERP_ZQ_IF006_RESP.SI_WZERP_ZQ_IF006_RESP_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_ZQ_IF006_RESP.SI_WZERP_ZQ_IF006_RESP_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //EC反馈ZQ框架协议审批状态处理结果服务接口定义
        #region
        public string TEST_ZQIF006RESP(string strItem)
        {
            string[] strItemArr = strItem.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            Model.ZQIF006_RESPmodel respModel = new ZQIF006_RESPmodel();


            SetPropertyValue(strItemArr, respModel);


            SI_WZERP_ZQ_IF006_RESP.DT_EC5_ZQ_IF006_RESPAGREEMENTAPPROVALRES dt = new SI_WZERP_ZQ_IF006_RESP.DT_EC5_ZQ_IF006_RESPAGREEMENTAPPROVALRES();
            dt.AGRRESDESC = respModel.AGRRESDESC;
            dt.AGRRESULT = respModel.AGRRESULT;
            dt.MSGID = respModel.MSGID;
            dt.SENDTIME = respModel.SENDTIME;
            dt.STRN = respModel.STRN;

            SI_WZERP_ZQ_IF006_RESP.DT_EC5_ZQ_IF006_RESP resp = new SI_WZERP_ZQ_IF006_RESP.DT_EC5_ZQ_IF006_RESP();

            resp.AGREEMENTAPPROVALRES = dt;
        
        #endregion
            try
            {
                client.SI_WZERP_ZQ_IF006_RESP_A_OUT(resp);
                return "S";
            }
            catch (Exception ex)
            {
                return "程序报错！" + ex.Message + ex.Source;
            }
        }

    }
}

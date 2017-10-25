using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class HT_CONTRACT_CLOSED_RESULTService : ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService();

        }

        public SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }


        //调用接口 
        public string TEST_CLOSED_RESULT(string RESULTstr,string CONTRACTITEMRESULTstr)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";
            string[] RESULTArr = RESULTstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] CONTRACTITEMRESULTArr = CONTRACTITEMRESULTstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            //参数赋值
            Model.CONTRACTITEMRESULTModel CONTRACTITEMRESULTModel = new Model.CONTRACTITEMRESULTModel();
            SetPropertyValue(CONTRACTITEMRESULTArr, CONTRACTITEMRESULTModel);

            Model.CONTRACT_CLOSED_RESULTModel RESULModel = new Model.CONTRACT_CLOSED_RESULTModel();
            SetPropertyValue(RESULTArr, RESULModel);


            SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT[] CONTRACTITEMRESULT = {

             new SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT(){
 
              INVOICEITEM = CONTRACTITEMRESULTModel.INVOICEITEM,
              RESDESC = CONTRACTITEMRESULTModel.RESDESC,
             }};

            SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.DT_EC5_CONTRACT_PAID_RESULT RESULT = new SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.DT_EC5_CONTRACT_PAID_RESULT();
            RESULT.STRSYSNUMBER = RESULModel.STRSYSNUMBER;
            RESULT.RESULT = RESULModel.RESULT;
            RESULT.RESTIME = RESULModel.RESTIME;
            RESULT.RESDESC = RESULModel.RESDESC;
            RESULT.MSGID = RESULModel.MSGID;
            RESULT.CONTRACTITEMRESULT = CONTRACTITEMRESULT;
            RESULT.VBELN = RESULModel.VBELN;
            try
            {
                client.SI_EC5_CONTRACT_CLOSED_RESULT_A_OUT(RESULT);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message + ex.Source;
            }

        }
    }
}

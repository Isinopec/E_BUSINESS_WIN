using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;
using System.Net;
using WZERP_E_BUSINESS.Model;

namespace WZERP_E_BUSINESS.UserService
{
    public class PAY_CONTRACT_RESPService:ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_PAY_CONTRACT_RESP.SI_EC5_WZERP_PAY_CONTRACT_RESP_A_OUTService();
        }
        public SI_WZERP_PAY_CONTRACT_RESP.SI_EC5_WZERP_PAY_CONTRACT_RESP_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_PAY_CONTRACT_RESP.SI_EC5_WZERP_PAY_CONTRACT_RESP_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var mes ="创建服务错误"+ ex.Message ;
                return false;
            }
            return true;
        }

        public string  TEST_PAY_CONTRACT_RESP(string strHeader,string strItem )
        {
            //数据处理
            string[] strHeaderArr = strHeader.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = strItem.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            PAY_CONTRACT_RESPmodel PayModel = new PAY_CONTRACT_RESPmodel();
            CONTRACTITEMRESULTTmodel ConItemModel = new CONTRACTITEMRESULTTmodel();
            SetPropertyValue(strHeaderArr, ConItemModel);//结构参数赋值
            SetPropertyValue(itemArr, PayModel);//参数赋值

            //结构参数赋值
            SI_WZERP_PAY_CONTRACT_RESP.DT_EC5_PAY_CONTRACT_RESULTCONTRACTITEMRESULT[] items = {new SI_WZERP_PAY_CONTRACT_RESP.DT_EC5_PAY_CONTRACT_RESULTCONTRACTITEMRESULT(){
                 ITEMNO = ConItemModel.ITEMNO,
                  RESDESC = ConItemModel.RESDESC,
            }};

            SI_WZERP_PAY_CONTRACT_RESP.DT_EC5_PAY_CONTRACT_RESULT PayRe = new SI_WZERP_PAY_CONTRACT_RESP.DT_EC5_PAY_CONTRACT_RESULT();
            PayRe.EBELN = PayModel.EBELN;
            PayRe.MSGID = PayModel.MSGID;
            PayRe.RESDESC = PayModel.RESDESC;
            PayRe.RESTIME = PayModel.RESTIME;
            PayRe.RESULT = PayModel.RESULT;
            PayRe.STRSYSNUMBER = PayModel.STRSYSNUMBER;
            PayRe.CONTRACTITEMRESULT = items;

            try
            {
                client.SI_EC5_WZERP_PAY_CONTRACT_RESP_A_OUT(PayRe);
                return "s";
            }
            catch (Exception ex)
            {
                return ex.Message + ex.Source;
            }
         


        }


    }
}

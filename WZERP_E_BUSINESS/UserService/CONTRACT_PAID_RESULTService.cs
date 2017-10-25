using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Services.Protocols;
using System.Reflection;
using WZERP_E_BUSINESS.Model;
namespace WZERP_E_BUSINESS.UserService
{
    public class CONTRACT_PAID_RESULTService:ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_ERP_CONTRACT_PAID_RESULT.SI_EC5_CONTRACT_PAID_RESULT_A_OUTService();
        }
        public SI_ERP_CONTRACT_PAID_RESULT.SI_EC5_CONTRACT_PAID_RESULT_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_ERP_CONTRACT_PAID_RESULT.SI_EC5_CONTRACT_PAID_RESULT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var mes = ex.Message + "创建服务错误";
                return false;
            }
            return true;
        }

        public string TEST_CONTRACT_PAID_RESULT(string strHeader, string strItem)
        {
            string[] strHeaderArr = strHeader.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = strItem.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            CONTRACTITEMRESULTmodel ItemModel = new CONTRACTITEMRESULTmodel();
            CONTRACT_PAID_RESULTmodel HeadModel = new CONTRACT_PAID_RESULTmodel();
            SetPropertyValue(strHeaderArr, HeadModel);
            SetPropertyValue(itemArr, ItemModel);

            SI_ERP_CONTRACT_PAID_RESULT.DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT[] ConItem = {new SI_ERP_CONTRACT_PAID_RESULT.DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT(){
                 INVOICEITEM = ItemModel.INVOICEITEM,
                 RESDESC = ItemModel.RESDESC,
            }};


            SI_ERP_CONTRACT_PAID_RESULT.DT_EC5_CONTRACT_PAID_RESULT ConPaid = new SI_ERP_CONTRACT_PAID_RESULT.DT_EC5_CONTRACT_PAID_RESULT();
            ConPaid.MSGID = HeadModel.MSGID;
            ConPaid.RESDESC = HeadModel.RESDESC;
            ConPaid.RESTIME = HeadModel.RESTIME;
            ConPaid.RESULT = HeadModel.RESULT;
            ConPaid.STRSYSNUMBER = HeadModel.STRSYSNUMBER;
            ConPaid.VBELN = HeadModel.VBELN;
            ConPaid.CONTRACTITEMRESULT = ConItem;

            try
            {
                client.SI_EC5_CONTRACT_PAID_RESULT_A_OUT(ConPaid);
                return "s";
            }
            catch (Exception ex)
            {
                 return ex.Message + ex.Source;
                    
            }


        }

    }
}

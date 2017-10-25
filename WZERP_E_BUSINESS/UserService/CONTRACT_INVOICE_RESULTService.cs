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

    public class CONTRACT_INVOICE_RESULTService : ServiceBase
    {
        //重写函数
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_ERP_CONTRACT_INVOICE_RESULT.SI_EC5_CONTRACT_INVOICE_RESULT_A_OUTService();
        }
        public SI_ERP_CONTRACT_INVOICE_RESULT.SI_EC5_CONTRACT_INVOICE_RESULT_A_OUTService client = null;

        //创建服务函数，判断服务是否连通
        public bool CreateService()
        {
            try
            {
                client = (SI_ERP_CONTRACT_INVOICE_RESULT.SI_EC5_CONTRACT_INVOICE_RESULT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var mag = "创建服务错误" + ex.Message;
                return false;
            }
            return true;
        }
        //接口调用方法，strItem传入参数
        public string Test_CONTRACT_INVOICE_RESULT(string strHeader, string strItem)
        {

            string[] strHeaderArr = strHeader.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = strItem.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            
            
            CONTRACT_INVOICE_RESULTmodel IVmodel = new CONTRACT_INVOICE_RESULTmodel();
            itemsmodel headC = new itemsmodel();
            SetPropertyValue(itemArr, IVmodel);
            SetPropertyValue(strHeaderArr, headC);

            //结构赋值
            SI_ERP_CONTRACT_INVOICE_RESULT.DT_EC5_CONTRACT_INVOICE_RESULTINVOICEMATRESULT[] items = {new SI_ERP_CONTRACT_INVOICE_RESULT.DT_EC5_CONTRACT_INVOICE_RESULTINVOICEMATRESULT(){
                     INVOICEITEM = headC .INVOICEITEM,
                     PRODCODE = headC.PRODCODE,
                     RESDESC =headC .RESDESC,
                  }};


            SI_ERP_CONTRACT_INVOICE_RESULT.DT_EC5_CONTRACT_INVOICE_RESULT CR = new SI_ERP_CONTRACT_INVOICE_RESULT.DT_EC5_CONTRACT_INVOICE_RESULT();
                //参数赋值
                CR.CORPCODE = IVmodel.CORPCODE;
                CR.RESDESC = IVmodel.RESDESC;
                CR.MSGID = IVmodel.MSGID;
                CR.RESTIME = IVmodel.RESTIME;
                CR.RESULT = IVmodel.RESULT;
                CR.STRSYSNUMBER = IVmodel.STRSYSNUMBER;
                CR.VATNO = IVmodel.VATNO;
                CR.VBELN = IVmodel.VBELN;
                CR.INVOICEMATRESULT = items;
  
            try
            {
                client.SI_EC5_CONTRACT_INVOICE_RESULT_A_OUT(CR);
                return "s";
            }

            catch (Exception ex)
            {
                return "程序报错！" + ex.Message + ex.Source;
            }

        }
    }
}

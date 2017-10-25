using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Services.Protocols;

namespace WZERP_E_BUSINESS.UserService
{
    public class IDEC_EMARKET_PO_CONFIRMService :ServiceBase
    {
        //创建saop协议
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_IDEC_EMARKET_PO_CONFIRM.SI_IDEC_EMARKET_PO_CONFIRM_A_OUTService();
        }
        public SI_IDEC_EMARKET_PO_CONFIRM.SI_IDEC_EMARKET_PO_CONFIRM_A_OUTService client = null;

        //创建服务
        public bool CreateService()
        {
            try
            {
                client = (SI_IDEC_EMARKET_PO_CONFIRM.SI_IDEC_EMARKET_PO_CONFIRM_A_OUTService)this.CreateSoapProxy();
                return true;

            }
            catch (Exception ex)
            {
                var msg = "创建服务出错" + ex.Message;
                return false;
            }
        }

        //创建接口调用函数
        public string TEST_IDEC_EMARKET(string ZMROSDZCSMIGOHstr, string ZMROSDZCSMIGOLstr)
        {
            string [] ZMROSDZCSMIGOHArr = ZMROSDZCSMIGOHstr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            string [] ZMROSDZCSMIGOLArr = ZMROSDZCSMIGOLstr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            //ZMROSDZCSMIGOH结构给值
             List<SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOH>  ZMROSDZCSMIGOH_LIST  = new List<SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOH>();
             for (var i = 0; i < ZMROSDZCSMIGOHArr.Length; i++)
             {
                 SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOH ZMROSDZCSMIGOH = new SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOH();
                 var tmpArr = ZMROSDZCSMIGOHArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                 SetPropertyValue(tmpArr, ZMROSDZCSMIGOH);
                 ZMROSDZCSMIGOH_LIST.Add(ZMROSDZCSMIGOH);
             }

                //ZMROSDZCSMIGOL结构给值
             List<SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOL> ZMROSDZCSMIGOL_List = new List<SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOL>();
             for (var j = 0; j < ZMROSDZCSMIGOLArr.Length; j++)
             {
                 SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOL ZMROSDZCSMIGOL = new SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRMIT_ZMROSDZCSMIGOL();
                 var tmpsArr = ZMROSDZCSMIGOLArr[j].Split(new string[] { "@__@" }, StringSplitOptions.None);
                 SetPropertyValue(tmpsArr, ZMROSDZCSMIGOL);
                 ZMROSDZCSMIGOL_List.Add(ZMROSDZCSMIGOL);
             }
           
                //CONFIRM给值
             SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRM CONFIRM = new SI_IDEC_EMARKET_PO_CONFIRM.DT_IDEC_EMARKET_PO_CONFIRM();
             CONFIRM.IT_ZMROSDZCSMIGOH = ZMROSDZCSMIGOH_LIST.ToArray();
             CONFIRM.IT_ZMROSDZCSMIGOL = ZMROSDZCSMIGOL_List.ToArray();

             try
             {
                 client.SI_IDEC_EMARKET_PO_CONFIRM_A_OUT(CONFIRM);
                 return "S";
             }
             catch (Exception ex)
             {
                 return "程序报错！" + ex.Message + ex.Source;
             }
        }
    }
}

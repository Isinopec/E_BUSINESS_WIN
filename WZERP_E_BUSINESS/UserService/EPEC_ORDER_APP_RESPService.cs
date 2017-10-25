using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;
namespace WZERP_E_BUSINESS.UserService
{
    public class EPEC_ORDER_APP_RESPService :ServiceBase
    {
        //重载函数InstanceProxy,创建soap协议
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EPEC_ORDER_APP_RESP.SI_EPEC_ORDER_APP_RESP_A_OUTService();

        }

        public SI_EPEC_ORDER_APP_RESP.SI_EPEC_ORDER_APP_RESP_A_OUTService client = null;

        //创建服务
        public bool CreateService()
        {
            try
            {
                client = (SI_EPEC_ORDER_APP_RESP.SI_EPEC_ORDER_APP_RESP_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch(Exception ex)
            {
                var msg = "创建服务出错" + ex.Message;
                return false;
            }
        }

        public string TEST_EPEC_ORDER_APP_RESP(string msgHeadstr, string respHeadstr)
        {
            string[] msgHeadArr = msgHeadstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            //string[] respHeadArr = respHeadstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] respHeadArr = respHeadstr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            
            SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIS_MSG_HEAD MSG_HEADModel = new SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIS_MSG_HEAD();
            SetPropertyValue(msgHeadArr, MSG_HEADModel);
            SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD RESP_HEADModel = new SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD();
            List<SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD> RESPlist = new List<SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD>();

            for (var i = 0; i < respHeadArr.Length; i++)
            {
                SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD RESP_HEAD = new SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESPIT_RESP_HEAD();
                var tmpArr = respHeadArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpArr, RESP_HEAD);
                RESPlist.Add(RESP_HEAD);

            }


            SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESP resp = new SI_EPEC_ORDER_APP_RESP.DT_EPEC_ORDER_APP_RESP();
            resp.IS_MSG_HEAD = MSG_HEADModel;
            resp.IT_RESP_HEAD = RESPlist.ToArray();

            try
            {
                client.SI_EPEC_ORDER_APP_RESP_A_OUT(resp);
                return "S";
            }

            catch (Exception ex)
            {
                return "程序报错！" + ex.Message + ex.Source;
            }


        }

    }
}

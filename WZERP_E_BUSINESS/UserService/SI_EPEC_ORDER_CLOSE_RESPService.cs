using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
namespace WZERP_E_BUSINESS.UserService
{
    public class SI_EPEC_ORDER_CLOSE_RESPService:ServiceBase
    {
        //重写InstanceProxy创建soap协议
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return  new SI_EPEC_ORDER_CLOSE_RESP.SI_EPEC_ORDER_CLOSE_RESP_A_OUTService();
        }

        public SI_EPEC_ORDER_CLOSE_RESP.SI_EPEC_ORDER_CLOSE_RESP_A_OUTService client = null;

        //创建服务
        public bool CreateService()
        {
            try
            {
                client = (SI_EPEC_ORDER_CLOSE_RESP.SI_EPEC_ORDER_CLOSE_RESP_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch(Exception ex)
            {
                var msg = "创建服务出错" + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// 易派客反馈合同关闭状态处理结果接口
        /// </summary>
        /// <param name="msgHeadstr">MSG_HEAD</param>
        /// <param name="respHeadstr">RESP</param>
        /// <returns></returns>
        public string Test_Epec_Close(string msgHeadstr,string respHeadstr)
        {
            string[] msgHeadArr = msgHeadstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] respHeadArr = respHeadstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            //DT_EPEC_ORDER_CLOSE_RESPIS_MSG_HEAD 实体赋值
            SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESPIS_MSG_HEAD msg_headModel = new SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESPIS_MSG_HEAD();
            SetPropertyValue(msgHeadArr, msg_headModel);

            //DT_EPEC_ORDER_CLOSE_RESPIS_RESP_HEAD 实体赋值
            SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESPIS_RESP_HEAD resp_headModel = new SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESPIS_RESP_HEAD();
            SetPropertyValue(respHeadArr, resp_headModel);

            //DT_EPEC_ORDER_CLOSE_RESP 实体赋值
            SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESP resp = new SI_EPEC_ORDER_CLOSE_RESP.DT_EPEC_ORDER_CLOSE_RESP();
            resp.IS_MSG_HEAD = msg_headModel;
            resp.IS_RESP_HEAD = resp_headModel;

            try
            {
                client.SI_EPEC_ORDER_CLOSE_RESP_A_OUT(resp);
                return "S";
            }
            catch (Exception ex)
            {
                return "调用程序出错，请检查参数:"+ex.Message;
            }
        }


    }
}

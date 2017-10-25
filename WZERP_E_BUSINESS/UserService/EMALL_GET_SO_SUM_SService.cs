using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.UserService
{
    public class EMALL_GET_SO_SUM_SService:ServiceBase
    {
        //重写InstanceProxy创建soap协议
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EMALL_GET_SO_SUM_S.SI_EMALL_GET_SO_SUM_S_OUTService();
        }

        private SI_EMALL_GET_SO_SUM_S.SI_EMALL_GET_SO_SUM_S_OUTService client = null;

        //创建服务
        public bool CreateService()
        {
            try
            {
                client = (SI_EMALL_GET_SO_SUM_S.SI_EMALL_GET_SO_SUM_S_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch (Exception ex)
            {
                var msg = "创建服务出错" + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// E贸网批量查询订单总金额接口
        /// </summary>
        /// <param name="msgHeadStr">msg_head</param>
        /// <param name="vBELNStr">VBELN</param>
        /// <returns></returns>
        public string Test_EMALL_Get_Sum(string msgHeadStr,string vBELNStr)
        {
            string[] msgHeadArr = msgHeadStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] vBELNArr = vBELNStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);

            //MSG_HEAD
            SI_EMALL_GET_SO_SUM_S.MSG_HEAD msgHeadMode = new SI_EMALL_GET_SO_SUM_S.MSG_HEAD();
            SetPropertyValue(msgHeadArr, msgHeadMode);

            //EBELN[]
            List<SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQIT_VBELN> eBELNList = new List<SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQIT_VBELN>();
            for (var i = 0; i < vBELNArr.Length; i++)
            {
                SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQIT_VBELN eBELNModel = new SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQIT_VBELN();

                var tmpArr = vBELNArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpArr, eBELNModel);//设置属性值

                eBELNList.Add(eBELNModel);
            }

            //REQ
            SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQ req = new SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_REQ();
            req.IS_MSG_HEAD = msgHeadMode;
            req.IT_VBELN = eBELNList.ToArray();
            req.IV_TESTRUN = "X";

            //RESP
            SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_RESP res = new SI_EMALL_GET_SO_SUM_S.DT_GET_SO_SUM_RESP();

           
            try
            {
                res = client.SI_EMALL_GET_SO_SUM_S_OUT(req);
                
                return "S";
            }
            catch(Exception Ex)
            {
                var msg = Ex.Message;
                return "程序运行报错:" + msg;
            }

            //
            SI_EMALL_GET_SO_SUM_S.DT_BAPIRET2[] ret = res.ET_RETURN.ToArray();


        }

    }
}

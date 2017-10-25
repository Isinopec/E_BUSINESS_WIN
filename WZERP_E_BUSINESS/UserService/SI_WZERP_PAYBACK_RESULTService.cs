using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS;

namespace WZERP_E_BUSINESS.UserService
{
    public class SI_WZERP_PAYBACK_RESULTService:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_PAYBACK_RESULT1.SI_WZERP_PAYBACK_RESULT_A_OUTService();
        }
        SI_WZERP_PAYBACK_RESULT1.SI_WZERP_PAYBACK_RESULT_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_PAYBACK_RESULT1.SI_WZERP_PAYBACK_RESULT_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }

        //测试方法
        public string Test_WZERP_PAYBACK_RESULT(string headStr, string RESPData)
        {

            try
            {
                SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESP iv=new SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESP();
                
                string[] headArr = headStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
                string[] respArr = RESPData.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);


                #region DT_WZERP_PAYBACK_RESPIS_MSG_HEAD 赋值
                SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESPIS_MSG_HEAD msgHeadModel = new SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESPIS_MSG_HEAD();
                SetPropertyValue(headArr, msgHeadModel);
   
                #endregion

                #region DT_WZERP_PAYBACK_RESPIS_PAYBACK_RESP 赋值

                SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESPIS_PAYBACK_RESP msgRespModel = new SI_WZERP_PAYBACK_RESULT1.DT_WZERP_PAYBACK_RESPIS_PAYBACK_RESP();
                SetPropertyValue(respArr, msgRespModel);

                #endregion


                iv.IS_MSG_HEAD = msgHeadModel;
                iv.IS_PAYBACK_RESP = msgRespModel;
                try
                {
                    client.SI_WZERP_PAYBACK_RESULT_A_OUT(iv);
                    return "S";
                }
                catch (Exception ex)
                {
                    return "程序运行报错：" + ex.Message + ex;
                }
            }
            catch (Exception ex)
            {
                return "参数赋值错误：" + ex.Message + ex;
            }



        }
    }
}

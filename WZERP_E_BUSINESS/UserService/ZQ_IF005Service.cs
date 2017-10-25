using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Net;
using System.Reflection;
using WZERP_E_BUSINESS.Model;

namespace WZERP_E_BUSINESS.UserService
{
    public class ZQ_IF005Service:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF005.SI_WZERP_ZQ_IF005_A_OUTService();
        }
        private SI_WZERP_ZQ_IF005.SI_WZERP_ZQ_IF005_A_OUTService client = null;

        //创建服务,网络验证
        public bool CreateService()
        {
            //SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService proxy1 = new SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService();
            //proxy1.Timeout =1000*60*60;
            //proxy1.Credentials = new NetworkCredential("RFCATUSER","q123456");

            try
            {
                client = (SI_WZERP_ZQ_IF005.SI_WZERP_ZQ_IF005_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务对象错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //接口维护项目预算
        public string TEST_ZQ_IF005(string itemstr)
        {

          //  string[] strHeadarr = headstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strItemarr = itemstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            SI_WZERP_ZQ_IF005.DT_EC5_ZQ_IF005_REQ iv = new SI_WZERP_ZQ_IF005.DT_EC5_ZQ_IF005_REQ();

            try
            {
             

                #region item information
                var itemp = new ZQ_IF005Model();
               var ipt = itemp.GetType();
               /*string     names= null;
                //拼接字符串 string     names
                foreach (PropertyInfo pitem in ipt.GetProperties())
                {

                    names = pitem.Name.ToUpper()+ "@_@1701@__@"+names;
                    
                       
                    
                }*/

                for (int i = 0; i < strItemarr.Length; i++)
                {
                    string[] itemArr = strItemarr[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                    foreach (PropertyInfo pitem in ipt.GetProperties())
                    {
                        if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                        {
                            ipt.GetProperty(pitem.Name).SetValue(itemp, itemArr[1].ToString());
                        }
                    }
                }

                //item



                SI_WZERP_ZQ_IF005.DT_EC5_ZQ_IF005_REQAGREEMENTOPEN op = new SI_WZERP_ZQ_IF005.DT_EC5_ZQ_IF005_REQAGREEMENTOPEN();
                op.MSGID = itemp.mSGID;

                op.STRN = itemp.sTRN;

                op.SENDTIME = itemp.sENDTIME;

                op.XGYY = itemp.xGYY;

                op.AGRCODE = itemp.aGRCODE;

                op.SAPAGRCODE = itemp.sAPAGRCODE;

                op.MODIFYCODE = itemp.mODIFYCODE;

                op.OPERATETYPE = itemp.oPERATETYPE;

                op.YL1 = itemp.yL1;

                op.YL2 = itemp.yL2;

                op.YL3 = itemp.yL3;

                op.YL4 = itemp.yL4;

                op.YL5 = itemp.yL5;



          
            iv.AGREEMENTOPEN = op;
              
                #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }

            try
            {

                client.SI_WZERP_ZQ_IF005_A_OUT(iv);
                return "S";
                 
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "程序报错:" + ex.Message + ex.Source;
            }
        }
    }
}

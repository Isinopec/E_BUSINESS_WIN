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
    public class ZQ_IF003Service:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF003.SI_WZERP_ZQ_IF003_A_OUTService();
        }
        private SI_WZERP_ZQ_IF003.SI_WZERP_ZQ_IF003_A_OUTService client = null;

        //创建服务,网络验证
        public bool CreateService()
        {
            //SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService proxy1 = new SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService();
            //proxy1.Timeout =1000*60*60;
            //proxy1.Credentials = new NetworkCredential("RFCATUSER","q123456");

            try
            {
                client = (SI_WZERP_ZQ_IF003.SI_WZERP_ZQ_IF003_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务对象错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //接口维护项目预算
        public string TEST_ZQ_IF003(string itemstr)
        {

          //  string[] strHeadarr = headstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strItemarr = itemstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            SI_WZERP_ZQ_IF003.DT_EC5_ZQ_IF003_REQ iv = new SI_WZERP_ZQ_IF003.DT_EC5_ZQ_IF003_REQ();

            try
            {
             

                #region item information
                var itemp = new ZQ_IF003Model();
                var ipt = itemp.GetType();
                string     names= null;
                //拼接字符串 string     names
                foreach (PropertyInfo pitem in ipt.GetProperties())
                {

                    names = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names;
                    
                       
                    
                }

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
              


                SI_WZERP_ZQ_IF003.DT_EC5_ZQ_IF003_REQAGREEMENTCLOSE cl = new SI_WZERP_ZQ_IF003.DT_EC5_ZQ_IF003_REQAGREEMENTCLOSE();
                cl.MSGID = itemp.mSGID;

         cl.STRN = itemp.sTRN;

         cl.SENDTIME = itemp.sENDTIME;

         cl.AGRSTATUS = itemp.aGRSTATUS;

         cl.OPERATEUSER = itemp.oPERATEUSER;

         cl.OPERATEDATE = itemp.oPERATEDATE;

         cl.AGRCODE = itemp.aGRCODE;

         cl.SAPAGRCODE = itemp.sAPAGRCODE;

         cl.MODIFYCODE = itemp.mODIFYCODE;

         cl.OPERATETYPE = itemp.oPERATETYPE;

         cl.YL1 = itemp.yL1;
            
         cl.YL2 = itemp.yL2;

         cl.YL3 = itemp.yL3;

         cl.YL4 = itemp.yL4;

         cl.YL5 = itemp.yL5;


          
            iv.AGREEMENTCLOSE = cl;
              
                #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }

            try
            {

                client.SI_WZERP_ZQ_IF003_A_OUT(iv);
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

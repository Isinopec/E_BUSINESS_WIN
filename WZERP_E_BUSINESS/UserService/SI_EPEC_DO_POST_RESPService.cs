
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
    public class SI_EPEC_DO_POST_RESPService:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EPEC_DO_POST_RESP.SI_EPEC_DO_POST_RESP_A_OUTService();
        }
        private SI_EPEC_DO_POST_RESP.SI_EPEC_DO_POST_RESP_A_OUTService client = null;

        //创建服务,网络验证
        public bool CreateService()
        {
            //SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService proxy1 = new SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService();
            //proxy1.Timeout =1000*60*60;
            //proxy1.Credentials = new NetworkCredential("RFCATUSER","q123456");

            try
            {
                client = (SI_EPEC_DO_POST_RESP.SI_EPEC_DO_POST_RESP_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务对象错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //接口维护项目预算
        public string TEST_POST_RESP(string headstr, string itemstr)
        {

           string[] strHeadarr = headstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strItemarr = itemstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESP iv = new SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESP();

            try
            {
             

                #region item information
                var itemp = new SI_EPEC_DO_POST_RESPModel();
                var ipt = itemp.GetType();
                string     names= null;
                //拼接字符串 string     names
                #region get coul
                foreach (PropertyInfo pitem in ipt.GetProperties())
                {

                    names = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names;
                    
                       
                    
                }//
              
               #endregion
                for (int i = 0; i < strHeadarr.Length; i++)
                {
                    string[] itemArr = strHeadarr[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                    foreach (PropertyInfo pitem in ipt.GetProperties())
                    {
                        if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                        {
                            ipt.GetProperty(pitem.Name).SetValue(itemp, itemArr[1].ToString());
                        }
                    }
                }
               
               //item
              


                SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESPIS_MSG_HEAD cl = new SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESPIS_MSG_HEAD();
                cl.MANDT = itemp.mANDT;

                cl.GUID = itemp.gUID;

                cl.PROXY_ID = itemp.pROXY_ID;

                cl.SYSTEM_ID = itemp.sYSTEM_ID;

                cl.OPERATOR = itemp.oPERATOR;

                cl.SPRAS = itemp.sPRAS;

                cl.INTERFACE_ID = itemp.iNTERFACE_ID;

                cl.SENDER = itemp.sENDER;

                cl.RECIVER = itemp.rECIVER;

                cl.SENDTIME = itemp.sENDTIME;


//123
         #region item information
         var itemp1 = new SI_EPEC_DO_POST_RESPISModel();
         var ipt1 = itemp1.GetType();
         string names1 = null;

         #region
                //拼接字符串 string     names
          foreach (PropertyInfo pitem in ipt1.GetProperties())
           {

               names1 = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names1;
                    
                       
                    
           }
         #endregion

         for (int i = 0; i < strItemarr.Length; i++)
         {
             string[] itemArr = strItemarr[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
             foreach (PropertyInfo pitem in ipt1.GetProperties())
             {
                 if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                 {
                     ipt1.GetProperty(pitem.Name).SetValue(itemp1, itemArr[1].ToString());
                 }
             }
         }

         //item



         SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESPIS_RESP_HEAD cl1 = new SI_EPEC_DO_POST_RESP.DT_EPEC_DO_POST_RESPIS_RESP_HEAD();
         cl1.ZZXXH = itemp1.zZXXH;

cl1.LOGSYS = itemp1.lOGSYS;

cl1.ZZEPECLN = itemp1.zZEPECLN;

cl1.ZZEPECSN = itemp1.zZEPECSN;

cl1.ZZEPECID = itemp1.zZEPECID;

cl1.MSGID = itemp1.mSGID;

cl1.ZCGBZ = itemp1.zCGBZ;

cl1.ZLOG = itemp1.zLOG;

cl1.EBELN = itemp1.eBELN;

cl1.ZZHTBH = itemp1.zZHTBH;

cl1.ZZDZCGHTH = itemp1.zZDZCGHTH;

cl1.MBLNR = itemp1.mBLNR;

cl1.ZZYL1 = itemp1.zZYL1;

cl1.ZZYL2 = itemp1.zZYL2;

cl1.ZZYL3 = itemp1.zZYL3;

cl1.ZZYL4 = itemp1.zZYL4;

cl1.ZZYL5 = itemp1.zZYL5;

cl1.ZZYL6 = itemp1.zZYL6;

cl1.ZZYL7 = itemp1.zZYL7;

cl1.ZZYL8 = itemp1.zZYL8;


          
            iv.IS_MSG_HEAD = cl;
            iv.IS_RESP_HEAD = cl1;
              
 #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }

            try
            {

                client.SI_EPEC_DO_POST_RESP_A_OUT(iv);
                return "S";
                 
            }
           
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "程序报错:" + ex.Message + ex.Source;
            }
        }
    }
#endregion
}
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
    public class ZQ_IF004Service:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF004.SI_WZERP_ZQ_IF004_A_OUTService();
        }
        private SI_WZERP_ZQ_IF004.SI_WZERP_ZQ_IF004_A_OUTService client = null;

        //创建服务,网络验证
        public bool CreateService()
        {
            //SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService proxy1 = new SI_IPM_PSBUDGET.SI_IPM_SEND_PSBUDGET_REQ_A_OUTService();
            //proxy1.Timeout =1000*60*60;
            //proxy1.Credentials = new NetworkCredential("RFCATUSER","q123456");

            try
            {
                client = (SI_WZERP_ZQ_IF004.SI_WZERP_ZQ_IF004_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务对象错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //接口维护项目预算
        public string TEST_ZQ_IF004(string itemstr1, string itemstr2,string itemstr3)
        {

            string[] strItemarr1 = itemstr1.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strItemarr2 = itemstr2.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strItemarr3 = itemstr3.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQ iv = new SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQ();

            try
            {
             

                #region item information
            var itemp1 = new ZQ_IF004_AGREEMENTWZERPCHGModle();
             /*用于调试获取各个属性字段
              * var itemp2 = new ZQ_IF004_AGREEMENTWZERPCHGFILEModle();
               var itemp3 = new ZQ_IF004_AGREEMENTWZERPCHGPRODUCTSModle();
              
                //拼接字符串 string     names
                var ipt1 = itemp3.GetType();
                string     names= null;
               foreach (PropertyInfo pitem in ipt1.GetProperties())
                {

                  
             names = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names;
                    
                       
                    
                }*/
                SetPropertyValue(strItemarr1,itemp1);

               /* for (int i = 0; i < strItemarr1.Length; i++)
                {
                    string[] itemArr = strItemarr1[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                    foreach (PropertyInfo pitem in ipt1.GetProperties())
                    {
                        if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                        {
                            ipt1.GetProperty(pitem.Name).SetValue(itemp1, itemArr[1].ToString());
                        }
                    }
                }*/

                //item



                SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG chg = new SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG();
                chg.MSGID = itemp1.mSGID;

                chg.STRN = itemp1.sTRN;

                chg.SENDTIME = itemp1.sENDTIME;

                chg.STARTDATE = itemp1.sTARTDATE;

                chg.ENDDATE = itemp1.eNDDATE;

                chg.TARGETVALUE = itemp1.tARGETVALUE;

                chg.STOCKTYPE = itemp1.sTOCKTYPE;

                chg.ATTRTYPE = itemp1.aTTRTYPE;

                chg.AGRCODE = itemp1.aGRCODE;

                chg.OPERATETYPE = itemp1.oPERATETYPE;

                chg.SAPAGRCODE = itemp1.sAPAGRCODE;

                chg.MODIFYCODE = itemp1.mODIFYCODE;

                chg.XGYY = itemp1.xGYY;

                chg.BGNR = itemp1.bGNR;

                chg.YL1 = itemp1.yL1;

                chg.YL2 = itemp1.yL2;

                chg.YL3 = itemp1.yL3;

                chg.YL4 = itemp1.yL4;

                chg.YL5 = itemp1.yL5;




          
            iv.AGREEMENTWZERPCHG= chg;
              
                #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }
            try
            {


                #region item information
                var itemp2 = new ZQ_IF004_AGREEMENTWZERPCHGFILEModle();
                var ipt2 = itemp2.GetType();
              //  string names = null;
                //拼接字符串 string     names
                /* foreach (PropertyInfo pitem in ipt.GetProperties())
                 {

                     names = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names;
                    
                       
                    
                 }*/
                SetPropertyValue(strItemarr2,itemp2);
                //for (int i = 0; i < strItemarr1.Length; i++)
                //{
                //    string[] itemArr = strItemarr1[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                //    foreach (PropertyInfo pitem in ipt2.GetProperties())
                //    {
                //        if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                //        {
                //            ipt2.GetProperty(pitem.Name).SetValue(itemp2, itemArr[1].ToString());
                //        }
                //    }
                //}

                //item



                SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] file ={ new SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE(){
               AGRCODE = itemp2.aGRCODE,

                ITEMNO = itemp2.iTEMNO,

                FILECODE = itemp2.fILECODE,

                FILENAME = itemp2.fILENAME,

                FILETYPE = itemp2.fILETYPE,

                FILEURL = itemp2.fILEURL,

                YL1 = itemp2.yL1,

            }};
                 
            iv.AGREEMENTWZERPCHGFILE = file.ToArray();





                

                #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }

            try
            {


                #region item information
                var itemp3 = new ZQ_IF004_AGREEMENTWZERPCHGPRODUCTSModle();
              //  var ipt1 = itemp1.GetType();
              //  string names = null;
                //拼接字符串 string     names
                /* foreach (PropertyInfo pitem in ipt.GetProperties())
                 {

                     names = pitem.Name.ToUpper()+ "@_@BJ1701@__@"+names;
                    
                       
                    
                 }*/
                /*
               * for (int i = 0; i < strItemarr1.Length; i++)
                {
                    string[] itemArr = strItemarr1[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                    foreach (PropertyInfo pitem in ipt1.GetProperties())
                    {
                        if (pitem.Name.ToUpper() == itemArr[0].ToUpper())
                        {
                            ipt1.GetProperty(pitem.Name).SetValue(itemp1, itemArr[1].ToString());
                        }
                    }
                }*/

                //item

                SetPropertyValue(strItemarr3, itemp3);

                SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] cts = {new SI_WZERP_ZQ_IF004.DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS(){
                AGRCODE = itemp3.aGRCODE,

                ITEMNO = itemp3.iTEMNO,

                PRODNAME = itemp3.pRODNAME,

                PRODCLASS = itemp3.pRODCLASS,

                QUANTITY = itemp3.qUANTITY,

                UNIT = itemp3.uNIT,

                PRICE = itemp3.pRICE,

                TAXCODE = itemp3.tAXCODE,

                YL1 = itemp3.yL1,

                YL2 = itemp3.yL2,

                YL3 = itemp3.yL3,

                YL4 = itemp3.yL4,

                YL5 = itemp3.yL5,



            }};


                iv.AGREEMENTWZERPCHGPRODUCTS = cts.ToArray();

                #endregion
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "数据预处理错误，请检查!" + ex.Message + ex.Source;
            }

            try
            {

                client.SI_WZERP_ZQ_IF004_A_OUT(iv);
                return "S";
                 
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
                return "程序报错:" + ex.Message + ex.Source;
            }
        }

       // public object itemp3 { get; set; }
    }
}

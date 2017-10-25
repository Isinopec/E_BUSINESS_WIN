using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS.Model;

namespace WZERP_E_BUSINESS.UserService
{
    public class SI_EPEC_CRT_ORDER_REQService : ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EPEC_CRT_ORDER_REQ_A_IN.SI_EPEC_CRT_ORDER_REQ_A_OUTService();
        }
        private SI_EPEC_CRT_ORDER_REQ_A_IN.SI_EPEC_CRT_ORDER_REQ_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_EPEC_CRT_ORDER_REQ_A_IN.SI_EPEC_CRT_ORDER_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务对象错误:" + ex.Message;
                return false;
            }
            return true;
        }

        public string Test_CRT_ORDER_REQ(string msgstr, string itemstr, string nxjhstr)
        {
            string[] msgHeadArr = msgstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] dditemArr = itemstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] nxjhHeadArr = nxjhstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            //Model
            SI_EPEC_CRT_ORDER_REQModel reqmodel = new SI_EPEC_CRT_ORDER_REQModel();
            DT_EPEC_CRT_ORDER_REQIT_DD_ITEMModel itemmodel = new DT_EPEC_CRT_ORDER_REQIT_DD_ITEMModel();
            DT_EPEC_CRT_ORDER_REQIT_NXJH_HEADModel nxjhmodel = new DT_EPEC_CRT_ORDER_REQIT_NXJH_HEADModel();

            //DT_EPEC_CRT_ORDER_REQIS_MSG_HEAD赋值
            SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIS_MSG_HEAD msghead = new SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIS_MSG_HEAD();
            SetPropertyValue(msgHeadArr, reqmodel);

            SetPropertyValue(dditemArr, itemmodel);

            SetPropertyValue(nxjhHeadArr, nxjhmodel);

            //
            msghead.GUID = reqmodel.GUID;
            msghead.INTERFACE_ID = reqmodel.iNTERFACE_ID;
            msghead.MANDT = reqmodel.MANDT;
            msghead.OPERATOR = reqmodel.oPERATOR;
            msghead.PROXY_ID = reqmodel.PROXY_ID;
            msghead.RECIVER = reqmodel.rECIVER;
            msghead.SENDER = reqmodel.sENDER;
            msghead.SENDTIME = reqmodel.sENDTIME;
            msghead.SPRAS = reqmodel.sPRAS;
            msghead.SYSTEM_ID = reqmodel.SYSTEM_ID;


            //DT_EPEC_CRT_ORDER_REQIT_DD_ITEM 
            SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIT_DD_ITEM[] ddItem ={new SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIT_DD_ITEM{
                
                EBELP=itemmodel.EBELP,
                EINDT=itemmodel.EINDT,
                KONNR=itemmodel.KONNR,
                MATNR=itemmodel.MATNR,
                MEINS=itemmodel.MEINS,
                MENGE=itemmodel.MENGE,
                MWSKZ=itemmodel.MWSKZ,
                NETPR=itemmodel.NETPR,
                VBELN=itemmodel.VBELN,
                VBELP=itemmodel.VBELP,
                WAERS=itemmodel.WAERS,
                ZZEPECSN=itemmodel.ZZEPECSN,
                ZZYL1=itemmodel.ZZYL1,
                ZZYL2=itemmodel.ZZYL2,
                ZZYL3=itemmodel.ZZYL3,
                ZZYL4=itemmodel.ZZYL4,
                ZZYL5=itemmodel.ZZYL5,
                ZZYL6=itemmodel.ZZYL6,
                ZZYL7=itemmodel.ZZYL7,
                ZZYL8=itemmodel.ZZYL8,
            }};

            //DT_EPEC_CRT_ORDER_REQIT_NXJH_HEAD
            SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIT_NXJH_HEAD[] nxjhHead ={new SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQIT_NXJH_HEAD{
                 DAOPT=nxjhmodel.DAOPT,
                 ERDAT=nxjhmodel.ERDAT,
                 INTSTATUS2=nxjhmodel.INTSTATUS2,
                 ISPO=nxjhmodel.ISPO,
                 LOGSYS=nxjhmodel.LOGSYS,
                 STRCONTIME=nxjhmodel.STRCONTIME,
                 STRMEMLOGNAME=nxjhmodel.STRMEMLOGNAME,
                 STRSUBTIME=nxjhmodel.STRSUBTIME,
                 URNAM=nxjhmodel.URNAM,
                 USEFLAG=nxjhmodel.USEFLAG,
                 ZKUUNR=nxjhmodel.ZKUUNR,
                 ZZEPECID=nxjhmodel.ZZEPECID,
                 ZZEPECLN=nxjhmodel.ZZEPECLN,
                 LIFNR=nxjhmodel.LIFNR,
                 ZZEPECLNSO=nxjhmodel.ZZEPECLNSO,
                 ZZEPECSN=nxjhmodel.ZZEPECSN,
                 ZZEPECSNSO=nxjhmodel.ZZEPECSNSO,
                 ZZHTLB=nxjhmodel.ZZHTLB,
                 ZZINTATTRTYPE=nxjhmodel.ZZINTATTRTYPE,
                 ZZKHSX=nxjhmodel.ZZKHSX,
                 ZZMANAMODE=nxjhmodel.ZZMANAMODE,
                 ZZXXH=nxjhmodel.ZZXXH,
                 ZZYF=nxjhmodel.ZZYF,
                 ZZYL1=nxjhmodel.ZZYL1,
                 ZZZFFSBM=nxjhmodel.ZZZFFSBM,
                 ZZYL2=nxjhmodel.ZZYL2,
                 ZZYL3=nxjhmodel.ZZYL3,
                 ZZYL4=nxjhmodel.ZZYL4,
                 ZZYL5=nxjhmodel.ZZYL5,
                 ZZYL6=nxjhmodel.ZZYL6,
                 ZZYL7=nxjhmodel.ZZYL7,
                 ZZYL8=nxjhmodel.ZZYL8,
            }};


            //DT_EPEC_CRT_ORDER_REQ
            SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQ req = new SI_EPEC_CRT_ORDER_REQ_A_IN.DT_EPEC_CRT_ORDER_REQ();
            req.IS_MSG_HEAD = msghead;
            req.IT_DD_ITEM = ddItem;
            req.IT_NXJH_HEAD = nxjhHead;

            try
            {
                client.SI_EPEC_CRT_ORDER_REQ_A_OUT(req);
                return "S";
            }
            catch (Exception ex)
            {
                return "调用程序出错，请检查参数:" + ex.Message;
            }


        }




    }
}

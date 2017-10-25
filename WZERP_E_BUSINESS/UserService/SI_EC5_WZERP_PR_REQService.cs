using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Services.Protocols;
using WZERP_E_BUSINESS.SI_EC5_WZERP_PR_REQ;
using WZERP_E_BUSINESS.Model;

namespace WZERP_E_BUSINESS.UserService
{
    public class SI_EC5_WZERP_PR_REQService : ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_WZERP_PR_REQ.SI_EC5_WZERP_PR_REQ_A_OUTService();
        }

        private SI_EC5_WZERP_PR_REQ.SI_EC5_WZERP_PR_REQ_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_WZERP_PR_REQ.SI_EC5_WZERP_PR_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //EC采购计划到物装ERP集成接口
        public string TEST_WZERP_PR_REQ(string strReq, string strReqPR)
        {
            string[] strReqArr = strReq.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strReqPRArr = strReqPR.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            #region SI_EC5_WZERP_PRREQUESTPURCHASEREQUESTModel information

            Model.SI_EC5_WZERP_PRREQUESTPURCHASEREQUESTModel req = new SI_EC5_WZERP_PRREQUESTPURCHASEREQUESTModel();
            SetPropertyValue(strReqPRArr, req);

            SI_EC5_WZERP_PR_REQ.DT_EC5_WZERP_PR_REQUESTPURCHASEREQUEST[] resmat = {new SI_EC5_WZERP_PR_REQ.DT_EC5_WZERP_PR_REQUESTPURCHASEREQUEST{
                
                STRORDERCODE=req.STRORDERCODE,
                STRCORPNAME=req.STRCORPNAME,
                STRPROJECTNO=req.STRPROJECTNO,
                STRPRODCODE=req.STRPRODCODE,
                STRPRODNAME=req.STRPRODNAME,
                INTQTY=req.INTQTY,
                STRUNIT=req.STRUNIT,
                STRSTANDARD=req.STRSTANDARD,
                INTBUDGETARY=req.INTBUDGETARY,
                DACONTIME=req.DACONTIME,
                STRCONADDR=req.STRCONADDR,
                STRMEMNAME=req.STRMEMNAME,
                STRMATERTYPE=req.STRMATERTYPE,
                STRUSERID=req.STRUSERID,
                DASUBTIME=req.DASUBTIME,
                STRURL=req.STRURL,
                STRPROJECTNM=req.STRPROJECTNM,
                STREQUIPNM=req.STREQUIPNM,
                STRLOCATION=req.STRLOCATION,
                STRDRAW=req.STRDRAW,
                STRPIECE=req.STRPIECE,
                STRSTANDALONE=req.STRSTANDALONE,
                STRAPPLY=req.STRAPPLY,
                STRHEAT=req.STRHEAT,
                STRRECEIVER=req.STRRECEIVER,
                NMATKL=req.NMATKL,
                STRMARK=req.STRMARK,
                ZBDBZ=req.ZBDBZ,
                DAPLANTIME=req.DAPLANTIME,
                STRPLANNO=req.STRPLANNO,
                STRSYSNUMBER=req.STRSYSNUMBER,
            }};
            #endregion

            #region
            SI_EC5_WZERP_PR_REQ.DT_EC5_WZERP_PR_REQUEST prreq = new SI_EC5_WZERP_PR_REQ.DT_EC5_WZERP_PR_REQUEST();
            Model.SI_EC5_WZERP_PR_REQModel reqmod = new SI_EC5_WZERP_PR_REQModel();
            SetPropertyValue(strReqArr, reqmod);

            prreq.BUSINESSTYPE = reqmod.BUSINESSTYPE;
            prreq.MSGID = reqmod.MSGID;
            prreq.STRSYSNUMBER = reqmod.STRSYSNUMBER;
            prreq.PURCHASEREQUEST = resmat;

            #endregion

            try
            {
                client.SI_EC5_WZERP_PR_REQ_A_OUT(prreq);
                return "S";
            }
            catch (Exception ex)
            {
                return "程序报错！" + ex.Message + ex.Source;
            }
        }
    }
}
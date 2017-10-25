using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class HT_CONTRACT_REQService : ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_ERP_CONTRACT_REQ1.SI_EC5_WZERP_CONTRACT_REQ_A_OUTService();

        }

        public SI_EC5_ERP_CONTRACT_REQ1.SI_EC5_WZERP_CONTRACT_REQ_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_ERP_CONTRACT_REQ1.SI_EC5_WZERP_CONTRACT_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }

        public string TEST_REQ(string REQTstr, string CONTRACTCONTRACTMATstr)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";
            string[] REQTArr = REQTstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] CONTRACTCONTRACTMATArr = CONTRACTCONTRACTMATstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            //参数赋值
            Model.CONTRACTMATREQModel CONTRACTCONTRACTMATModel = new Model.CONTRACTMATREQModel();
            SetPropertyValue(CONTRACTCONTRACTMATArr, CONTRACTCONTRACTMATModel);


            Model.CONTRACT_REQModel REQModel = new Model.CONTRACT_REQModel();
            SetPropertyValue(REQTArr, REQModel);




            ///SI_ERP_CONTRACT_CLOSED_RESULT_A_IN.DT_EC5_CONTRACT_PAID_RESULTCONTRACTITEMRESULT[] CONTRACTITEMRESULT = {
            SI_EC5_ERP_CONTRACT_REQ1.CONTRACTCONTRACTMAT[] CONTRACTCONTRACTMAT = {
              new SI_EC5_ERP_CONTRACT_REQ1.CONTRACTCONTRACTMAT(){
               CONTADD = CONTRACTCONTRACTMATModel.CONTADD,
               ECORDERCODE = CONTRACTCONTRACTMATModel.ECORDERCODE,
               CORPCODE = CONTRACTCONTRACTMATModel.CORPCODE,
               INTAVGPRICE = CONTRACTCONTRACTMATModel.INTAVGPRICE,
               INTFREE = CONTRACTCONTRACTMATModel.INTFREE,
               INTOTHER = CONTRACTCONTRACTMATModel.INTOTHER,
               INTPRICE = CONTRACTCONTRACTMATModel.INTPRICE,
               INTQTY = CONTRACTCONTRACTMATModel.INTQTY,
               PRNO = CONTRACTCONTRACTMATModel.PRNO,
               PRODCODE = CONTRACTCONTRACTMATModel.PRODCODE,
               PRODDESC = CONTRACTCONTRACTMATModel.PRODDESC,
               SAVEAMOUNT = CONTRACTCONTRACTMATModel.SAVEAMOUNT,
               TAXCODE = CONTRACTCONTRACTMATModel.TAXCODE,
               TECHSTANDARD = CONTRACTCONTRACTMATModel.TECHSTANDARD,
               UNIT = CONTRACTCONTRACTMATModel.UNIT,
              
              }};
            SI_EC5_ERP_CONTRACT_REQ1.CONTRACT REQ = new SI_EC5_ERP_CONTRACT_REQ1.CONTRACT();
            REQ.ARRIVEPORT = REQModel.ARRIVEPORT;
            REQ.ATTRTYPE = REQModel.ATTRTYPE;
            REQ.CORPCODE = REQModel.CORPCODE;
            REQ.CONTRACTMAT = CONTRACTCONTRACTMAT;
            REQ.CORPCODEN4 = REQModel.CORPCODEN4;
            REQ.CREATEDATE = REQModel.CREATEDATE;
            REQ.CREATEUSER = REQModel.CREATEUSER;
            REQ.DASUBTIME = REQModel.DASUBTIME;
            REQ.ECPONO = REQModel.ECPONO;
            REQ.ENQUTYPE = REQModel.ENQUTYPE;
            REQ.ERPGROUP = REQModel.ERPGROUP;
            REQ.IFLAG = REQModel.IFLAG;
            REQ.DOWNLOADDATE = REQModel.DOWNLOADDATE;
            REQ.INTPFZC = REQModel.INTPFZC;
            REQ.ISPO = REQModel.ISPO;
            REQ.KONNR = REQModel.KONNR;
            REQ.MSGID = REQModel.MSGID;
            REQ.OUTPORT = REQModel.OUTPORT;
            REQ.PONO = REQModel.PONO;
            REQ.STOCKTYPE = REQModel.STOCKTYPE;
            REQ.STRSYSNUMBER = REQModel.STRSYSNUMBER;
            REQ.SUPPCODE = REQModel.SUPPCODE;
            REQ.VENDORCODE = REQ.VENDORCODE;

            try
            {
                client.SI_EC5_WZERP_CONTRACT_REQ_A_OUT(REQ);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message + ex.Source;
            }

        }

    }
}

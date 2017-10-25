using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class HT_LOGISTICS_CONTRACTService : ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_ERP_LOGISTICS_CONTRACT1.SI_EC5_LOGISTICS_CONTRACT_A_OUTService();

        }
        public SI_EC5_ERP_LOGISTICS_CONTRACT1.SI_EC5_LOGISTICS_CONTRACT_A_OUTService client = null;

        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_ERP_LOGISTICS_CONTRACT1.SI_EC5_LOGISTICS_CONTRACT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }
        public string TEST_LOGISTICS_CONTRACT(string CONTRACTWLstr, string CONTRACTWLCONTRACTWLMATstr)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";
            string[] CONTRACTWLArr = CONTRACTWLstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] CONTRACTWLCONTRACTWLMATArr = CONTRACTWLCONTRACTWLMATstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            //参数赋值
            Model.CONTRACTWLCONTRACTWLMAT CONTRACTWLCONTRACTWLMATModel = new Model.CONTRACTWLCONTRACTWLMAT();
            SetPropertyValue(CONTRACTWLCONTRACTWLMATArr, CONTRACTWLCONTRACTWLMATModel);

            Model.LOGISTICS_CONTRACTModel CONTRACTWLModel = new Model.LOGISTICS_CONTRACTModel();
            SetPropertyValue(CONTRACTWLArr, CONTRACTWLModel);

            SI_EC5_ERP_LOGISTICS_CONTRACT1.CONTRACTWLCONTRACTWLMAT[] CONTRACTWLCONTRACTWLMAT = {
                                                                                                
            new  SI_EC5_ERP_LOGISTICS_CONTRACT1.CONTRACTWLCONTRACTWLMAT(){
                DAENDDATE = CONTRACTWLCONTRACTWLMATModel.DAENDDATE,
                ECORDERCODE = CONTRACTWLCONTRACTWLMATModel.ECORDERCODE,
                ENQUTYPE = CONTRACTWLCONTRACTWLMATModel.ENQUTYPE,
                GNBGBJ = CONTRACTWLCONTRACTWLMATModel.GNBGBJ,
                GNCXF = CONTRACTWLCONTRACTWLMATModel.GNCXF,
                GNFYBZ = CONTRACTWLCONTRACTWLMATModel.GNFYBZ,
                DASTARTDATE = CONTRACTWLCONTRACTWLMATModel.DASTARTDATE,
                GNGKFY = CONTRACTWLCONTRACTWLMATModel.GNGKFY,
                GNKYF = CONTRACTWLCONTRACTWLMATModel.GNKYF,
                GNLYF = CONTRACTWLCONTRACTWLMATModel.GNLYF,
                GNQTFY = CONTRACTWLCONTRACTWLMATModel.GNQTFY,
                GNSYF = CONTRACTWLCONTRACTWLMATModel.GNSYF,
                GWBGBJ = CONTRACTWLCONTRACTWLMATModel.GWBGBJ,
                GWFYBZ = CONTRACTWLCONTRACTWLMATModel.GWFYBZ,
                GWGKFY = CONTRACTWLCONTRACTWLMATModel.GWGKFY,
                GWHYF = CONTRACTWLCONTRACTWLMATModel.GWHYF,
                GWKYF = CONTRACTWLCONTRACTWLMATModel.GWKYF,
                GWLYF = CONTRACTWLCONTRACTWLMATModel.GWLYF,
                GWQTFY = CONTRACTWLCONTRACTWLMATModel.GWQTFY,
                GWZXF = CONTRACTWLCONTRACTWLMATModel.GWZXF,
                INTAVGPRICE = CONTRACTWLCONTRACTWLMATModel.INTAVGPRICE,
                INTTAX = CONTRACTWLCONTRACTWLMATModel.INTTAX,
                PRNO = CONTRACTWLCONTRACTWLMATModel.PRNO,
                PRODCODE = CONTRACTWLCONTRACTWLMATModel.PRODCODE,
                TECHSTANDARD = CONTRACTWLCONTRACTWLMATModel.TECHSTANDARD,
                YFBZ = CONTRACTWLCONTRACTWLMATModel.YFBZ,
                YFHL = CONTRACTWLCONTRACTWLMATModel.YFHL,

            }};

            SI_EC5_ERP_LOGISTICS_CONTRACT1.CONTRACTWL CONTRACTWL = new SI_EC5_ERP_LOGISTICS_CONTRACT1.CONTRACTWL();
            CONTRACTWL.ARRIVEPORT = CONTRACTWLModel.ARRIVEPORT;
            CONTRACTWL.CONTRACTWLMAT = CONTRACTWLCONTRACTWLMAT;
            CONTRACTWL.CORPCODE = CONTRACTWLModel.CORPCODE;
            CONTRACTWL.CORPCODEN4 = CONTRACTWLModel.CORPCODEN4;
            CONTRACTWL.CREATEDATE = CONTRACTWLModel.CREATEDATE;
            CONTRACTWL.CREATEUSER = CONTRACTWLModel.CREATEUSER;
            CONTRACTWL.DASUBTIME = CONTRACTWLModel.DASUBTIME;
            CONTRACTWL.DOWNLOADDATE = CONTRACTWLModel.DOWNLOADDATE;
            CONTRACTWL.ECPONO = CONTRACTWLModel.ECPONO;
            CONTRACTWL.ERPGROUP = CONTRACTWLModel.ERPGROUP;
            CONTRACTWL.IFLAG = CONTRACTWLModel.IFLAG;
            CONTRACTWL.KONNR = CONTRACTWLModel.KONNR;
            CONTRACTWL.MSGID = CONTRACTWLModel.MSGID;
            CONTRACTWL.OUTPORT = CONTRACTWLModel.OUTPORT;
            CONTRACTWL.PONO = CONTRACTWLModel.PONO;
            CONTRACTWL.STOCKTYPE = CONTRACTWLModel.STOCKTYPE;
            CONTRACTWL.STRSYSNUMBER = CONTRACTWLModel.STRSYSNUMBER;
            CONTRACTWL.SUPPCODE = CONTRACTWLModel.SUPPCODE;
            CONTRACTWL.TOTALSAVEAMOUNT = CONTRACTWLModel.TOTALSAVEAMOUNT;
            CONTRACTWL.VENDORCODE = CONTRACTWLModel.VENDORCODE;





            try
            {
                client.SI_EC5_LOGISTICS_CONTRACT_A_OUT(CONTRACTWL);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message + ex.Source;
            }


        }
    }
}


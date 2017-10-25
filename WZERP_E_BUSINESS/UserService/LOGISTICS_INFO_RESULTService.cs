using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS;
using WZERP_E_BUSINESS.Model;
using System.Reflection;
using System.Web.Services.Protocols;

namespace WZERP_E_BUSINESS.UserService
{
    public class LOGISTICS_INFO_RESULTService : ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT.SI_EC5_LOGISTICS_INFO_RESULT_A_OUTService();
        }
        private WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT.SI_EC5_LOGISTICS_INFO_RESULT_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT.SI_EC5_LOGISTICS_INFO_RESULT_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建错误:" + ex.Message;
                return false;
            }
            return true;
        }

        //物装ERP物流订单信息发往EC处理结果反馈接口定义


        public string TEST_LOGISTICS_INFO_RESULT(string strResult, string strResultMat)
        {
            string[] strResultArr = strResult.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] strResmatArr = strResultMat.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            #region LOGISTICS_INFO_RESULTMATModel information

            Model.LOGISTICS_INFO_RESULTMATModel resmat = new LOGISTICS_INFO_RESULTMATModel();

            SetPropertyValue(strResmatArr, resmat);

            WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT.ContractWLPRResultRESULTMAT[] mat ={new  WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT.ContractWLPRResultRESULTMAT{
                ECORDERCODE = resmat.ECORDERCODE,
                POSNR = resmat.POSNR,
                RESDESC = resmat.RESDESC,
                RESTIME = resmat.RESTIME,
                RESULT = resmat.RESULT,
                VBELN = resmat.VBELN,
                VBPOS = resmat.VBPOS,
                VGBEL = resmat.VGBEL,
                ZZHTBH = resmat.ZZHTBH,
            }};
            #endregion

            #region SI_EC5_LOGISTICS_INFO_RESULTMODEL information

            SI_EC5_LOGISTICS_INFO_RESULT.ContractWLPRResult res = new SI_EC5_LOGISTICS_INFO_RESULT.ContractWLPRResult();

            Model.LOGISTICS_INFO_RESULTModel result = new LOGISTICS_INFO_RESULTModel();

            SetPropertyValue(strResultArr, result);

            res.MSGID = result.MSGID;
            res.SENDTIME = result.SENDTIME;
            res.STRSYSNUMBER = result.STRSYSNUMBER;
            res.RESULTMAT = mat;

            #endregion

            try
            {
                client.SI_EC5_LOGISTICS_INFO_RESULT_A_OUT(res);
                return "S";
            }
            catch (Exception ex)
            {
                return "程序报错！" + ex.Message + ex.Source;
            }
        }
    }
}
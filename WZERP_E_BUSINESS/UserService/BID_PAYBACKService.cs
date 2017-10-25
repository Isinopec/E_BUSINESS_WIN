using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class BID_PAYBACKService : ServiceBase
    {
        //重写proxy
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_BID_PAYBACK.SI_EC5_BID_PAYBACK_REQ_A_OUTService();
        }

        public SI_WZERP_BID_PAYBACK.SI_EC5_BID_PAYBACK_REQ_A_OUTService client = null;

        //验证身份 
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_BID_PAYBACK.SI_EC5_BID_PAYBACK_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }

        //调用接口 
        public string TEST_BID_PAYBACK(string itemStr)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";

            //参数赋值
            Model.BID_PAYBACKModel paybackModel = new Model.BID_PAYBACKModel();
            var proInstance = paybackModel.GetType();
            string[] itemArr = itemStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < itemArr.Length; i++)
            {
                var tmpArr = itemArr[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                foreach (PropertyInfo py in proInstance.GetProperties())
                {
                    if (py.Name.ToLower() == tmpArr[0].ToLower())
                    {
                        proInstance.GetProperty(py.Name).SetValue(paybackModel, tmpArr[1]);
                    }
                }
            }

            //参数结构赋值

            SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUESTBIDPAYBACKMATVOUCHER[] items0 = {new SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUESTBIDPAYBACKMATVOUCHER(){
             VOUCHERNO = paybackModel.VOUCHERNO,
              VOUCHERYEAR = paybackModel.VOUCHERYEAR,
                } };

            SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUESTBIDPAYBACKMAT[] items1 = {new SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUESTBIDPAYBACKMAT(){
             LINEITEM = paybackModel.LINEITEM,
             FUNDTYPE = paybackModel.FUNDTYPE,
             ZFPLX = paybackModel.ZFPLX,
             INVOICENO = paybackModel.INVOICENO,
             ORDERNO = paybackModel.ORDERNO,
             PACKCODE = paybackModel.PACKCODE,
             AMOUNT = paybackModel.AMOUNT,
             DEPOSIT = paybackModel.DEPOSIT,
             REMARK = paybackModel.REMARK,
               VOUCHER = items0.ToArray(), //内嵌结构赋值
                } };

            //结构参数赋值
            SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUEST iv = new SI_WZERP_BID_PAYBACK.DT_EC5_BID_PAYBACK_REQUEST();
            iv.SYSNUMER = paybackModel.SYSNUMER; //QH5800 固定值 
            iv.MSGID = paybackModel.MSGID;
            iv.COMPANY = paybackModel.COMPANY;
            iv.ZHKWYH = paybackModel.ZHKWYH;
            iv.BIDCONSIGN = paybackModel.BIDCONSIGN;
            iv.BIDFILECODE = paybackModel.BIDFILECODE;
            iv.GOODS = paybackModel.GOODS;
            iv.ITEMCODE = paybackModel.ITEMCODE;
            iv.ITEMNAME = paybackModel.ITEMNAME;
            iv.STRZBBM = paybackModel.STRZBBM;
            iv.STRCORPNAME = paybackModel.STRCORPNAME;
            iv.BILLDOCNUM = paybackModel.BILLDOCNUM;
            iv.ACCOUNTNAME = paybackModel.ACCOUNTNAME;
            iv.BANKNAME = paybackModel.BANKNAME;
            iv.ACCOUNTNUM = paybackModel.ACCOUNTNUM;
            iv.ACCEPTBANK = paybackModel.ACCEPTBANK;
            iv.TOTALAMOUNT = paybackModel.TOTALAMOUNT;
            iv.CURRENCY = paybackModel.CURRENCY;
            iv.RATE = paybackModel.RATE;
            iv.OPERATETYPE = paybackModel.OPERATETYPE;
            iv.DATUM = paybackModel.DATUM;
            iv.REALNAME = paybackModel.REALNAME;
            iv.ZZFPT = paybackModel.ZZFPT;
            iv.TEXCODE = paybackModel.TEXCODE;
            iv.BANK = paybackModel.BANK;
            iv.ACCOUNTNO = paybackModel.ACCOUNTNO;
            iv.ADDRESS = paybackModel.ADDRESS;
            iv.TEL = paybackModel.TEL;
            iv.ZDZYX = paybackModel.ZDZYX;
            iv.MOBILE = paybackModel.MOBILE;
            iv.ZBYZD1 = paybackModel.ZBYZD1;
            iv.ZBYZD2 = paybackModel.ZBYZD2;
            iv.ZBYZD3 = paybackModel.ZBYZD3;
            iv.ZBYZD4 = paybackModel.ZBYZD4;
            iv.ZBYZD5 = paybackModel.ZBYZD5;
               iv.BIDPAYBACKMAT = items1.ToArray(); //结构赋值

            try
            {
                client.SI_EC5_BID_PAYBACK_REQ_A_OUT(iv);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
    }
}

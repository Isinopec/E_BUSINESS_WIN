using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class BID_REFUNDService : ServiceBase
    {

        //重写proxy
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_BID_REFUND.SI_EC5_BID_REFUND_REQ_A_OUTService();
        }

        public SI_WZERP_BID_REFUND.SI_EC5_BID_REFUND_REQ_A_OUTService client = null;

        //验证身份 
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_BID_REFUND.SI_EC5_BID_REFUND_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }
        #region 调用接口
        public string TEST_BID_REFUND(string headStr, string itemStr, string item1Str)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";

           
            string[] headArr = headStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = itemStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
            string[] item1Arr = item1Str.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            #region VOUCHER 赋值

            Model.VOUCHER VOUmodel = new Model.VOUCHER();
            SetPropertyValue(item1Arr, VOUmodel);//设置属性值
    
            SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUESTBIDREFUNDMATVOUCHER[] VOU = { new SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUESTBIDREFUNDMATVOUCHER(){
                    VOUCHERNO  = VOUmodel.VOUCHERNO ,
                    VOUCHERYEAR  = VOUmodel.VOUCHERYEAR ,
                }};
            #endregion

            #region BIDREFUNDMAT 赋值
            Model.BIDREFUNDMAT REFUNDMATmodel = new Model.BIDREFUNDMAT();
            SetPropertyValue(itemArr, REFUNDMATmodel);

            SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUESTBIDREFUNDMAT[] MAT = {new SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUESTBIDREFUNDMAT(){
                    LINEITEM  = REFUNDMATmodel.LINEITEM ,
                    PACKCODE  = REFUNDMATmodel.PACKCODE ,
                    AMOUNT  = REFUNDMATmodel.AMOUNT ,
                    PAYEDMONEY  = REFUNDMATmodel.PAYEDMONEY ,
                    REMARK  = REFUNDMATmodel.REMARK ,
                       VOUCHER = VOU,

            }};

            #endregion

            #region 参数结构赋值 

            Model.BID_REFUNDModel REFUNDmodel = new Model.BID_REFUNDModel();
            SetPropertyValue(headArr, REFUNDmodel);

            SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUEST iv = new SI_WZERP_BID_REFUND.DT_EC5_BID_REFUND_REQUEST();
            iv.MSGID = REFUNDmodel.MSGID;
            iv.SYSNUMER = REFUNDmodel.SYSNUMER;
            iv.COMPANY = REFUNDmodel.COMPANY;
            iv.REFUNDREQNUM = REFUNDmodel.REFUNDREQNUM;
            iv.BIDCONSIGN = REFUNDmodel.BIDCONSIGN;
            iv.BIDFILECODE = REFUNDmodel.BIDFILECODE;
            iv.ITEMCODE = REFUNDmodel.ITEMCODE;
            iv.ITEMNAME = REFUNDmodel.ITEMNAME;
            iv.OPERATETYPE = REFUNDmodel.OPERATETYPE;
            iv.REFUNDTYPE = REFUNDmodel.REFUNDTYPE;
            iv.STRZBBM = REFUNDmodel.STRZBBM;
            iv.STRCORPNAME = REFUNDmodel.STRCORPNAME;
            iv.CURRENCY = REFUNDmodel.CURRENCY;
            iv.RATE = REFUNDmodel.RATE;
            iv.ACCOUNTNAME = REFUNDmodel.ACCOUNTNAME;
            iv.BANKNAME = REFUNDmodel.BANKNAME;
            iv.ACCOUNTNUM = REFUNDmodel.ACCOUNTNUM;
            iv.REALNAME = REFUNDmodel.REALNAME;
            iv.ZZFPT = REFUNDmodel.ZZFPT;
                iv.BIDREFUNDMAT = MAT;
            #endregion 

            try
            {
                client.SI_EC5_BID_REFUND_REQ_A_OUT(iv);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

    }
}

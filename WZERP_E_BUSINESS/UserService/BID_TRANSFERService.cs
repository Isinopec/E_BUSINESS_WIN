using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{
    public class BID_TRANSFERService : ServiceBase
    {

        //重写proxy
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_BID_TRANSFER.SI_WZERP_BID_TRANSFER_REQ_A_OUTService();
        }

        public SI_WZERP_BID_TRANSFER.SI_WZERP_BID_TRANSFER_REQ_A_OUTService client = null;

        //验证身份 
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_BID_TRANSFER.SI_WZERP_BID_TRANSFER_REQ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错：" + ex.Message;
                return false;
            }
            return true;
        }
        #region 调用接口
        public string TEST_BID_TRANSFER(string itemStr)
        {

            //itemStr =  "MSGID@_@111@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@111@__@BIDCONSIGN@_@111@__@BIDFILECODE@_@111";


            string[] itemArr = itemStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            #region 参数结构赋值

            Model.BID_TRANSFERModel TRANmodel = new Model.BID_TRANSFERModel();
            SetPropertyValue(itemArr, TRANmodel);//设置属性值


            SI_WZERP_BID_TRANSFER.DT_EC5_BID_TRANSFER_REQ iv = new SI_WZERP_BID_TRANSFER.DT_EC5_BID_TRANSFER_REQ();

            iv.BIDTRANSFER = new SI_WZERP_BID_TRANSFER.DT_EC5_BID_TRANSFER_REQBIDTRANSFER();
            iv.BIDTRANSFER.MSGID = TRANmodel.MSGID;
            iv.BIDTRANSFER.SYSNUMER = TRANmodel.SYSNUMER;
            iv.BIDTRANSFER.COMPANY = TRANmodel.COMPANY;
            iv.BIDTRANSFER.TRANSNUM = TRANmodel.TRANSNUM;
            iv.BIDTRANSFER.DJTYPE = TRANmodel.DJTYPE;
            iv.BIDTRANSFER.BIDCONSIGN = TRANmodel.BIDCONSIGN;
            iv.BIDTRANSFER.BIDFILECODE = TRANmodel.BIDFILECODE;
            iv.BIDTRANSFER.PACKID = TRANmodel.PACKID;
            iv.BIDTRANSFER.PACKCODE = TRANmodel.PACKCODE;
            iv.BIDTRANSFER.ZRBIDCONSIGN = TRANmodel.ZRBIDCONSIGN;
            iv.BIDTRANSFER.ZRBIDFILECODE = TRANmodel.ZRBIDFILECODE;
            iv.BIDTRANSFER.ZRPACKID = TRANmodel.ZRPACKID;
            iv.BIDTRANSFER.ZRPACKCODE = TRANmodel.ZRPACKCODE;
            iv.BIDTRANSFER.STRZBBM = TRANmodel.STRZBBM;
            iv.BIDTRANSFER.STRCORPNAME = TRANmodel.STRCORPNAME;
            iv.BIDTRANSFER.CURRENCY = TRANmodel.CURRENCY;
            iv.BIDTRANSFER.DJAMOUNT = TRANmodel.DJAMOUNT;
            iv.BIDTRANSFER.AMOUNT = TRANmodel.AMOUNT;
            iv.BIDTRANSFER.REMARK = TRANmodel.REMARK;
            iv.BIDTRANSFER.DATUM = TRANmodel.DATUM;
            iv.BIDTRANSFER.UZEIT = TRANmodel.UZEIT;
            iv.BIDTRANSFER.REALNAME = TRANmodel.REALNAME;
            iv.BIDTRANSFER.VOUCHER = TRANmodel.VOUCHER;
            iv.BIDTRANSFER.VOUCHERYEAR = TRANmodel.VOUCHERYEAR;
            iv.BIDTRANSFER.ZCZLX = TRANmodel.ZCZLX;

            #endregion

            try
            {
                client.SI_WZERP_BID_TRANSFER_REQ_A_OUT(iv);
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

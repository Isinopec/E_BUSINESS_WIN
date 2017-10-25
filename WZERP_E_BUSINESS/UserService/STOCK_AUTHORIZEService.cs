using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace WZERP_E_BUSINESS.UserService
{

    //EC采购委托到物装ERP集成接口服务接口定义
    public class STOCK_AUTHORIZEService:ServiceBase
    {
        //重写 
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_STOCK_AUTHORIZE.SI_EC5_STOCK_AUTHORIZE_REQ_A_OUTService();
        }
        //
        public SI_EC5_STOCK_AUTHORIZE.SI_EC5_STOCK_AUTHORIZE_REQ_A_OUTService client = null;


        //身份验证
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_STOCK_AUTHORIZE.SI_EC5_STOCK_AUTHORIZE_REQ_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }


        //调用接口
        public string TEST_STOCK_AUTHORIZE(string headStr ,string itemStr)
        {
            //
            string[] headArr = headStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = itemStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
 
            #region STOCKAUTHORIZELIST赋值
            Model.STOCKAUTHORIZELIST rizeModel = new Model.STOCKAUTHORIZELIST();
            SetPropertyValue(itemArr,rizeModel);
            //
            SI_EC5_STOCK_AUTHORIZE.DT_EC5_WZERP_STOCK_AUTHORIZE_REQSTOCKAUTHORIZELIST[] items = { new SI_EC5_STOCK_AUTHORIZE.DT_EC5_WZERP_STOCK_AUTHORIZE_REQSTOCKAUTHORIZELIST(){
                 DALEADTIME=rizeModel.DALEADTIME,
                 DASUBTIME = rizeModel.DASUBTIME,
                 INTATTRTYPE = rizeModel.INTATTRTYPE,
                 INTCOCODE=rizeModel.INTCOCODE,
                 INTCODE_TO=rizeModel.INTCODE_TO,
                 INTCODE_TRAN =rizeModel.INTCODE_TRAN,
                 INTFLAG=rizeModel.INTFLAG,
                 INTTYPE =rizeModel.INTTYPE,
                 PZWT_NO=rizeModel.PZWT_NO,
                 STRMEMNAME=rizeModel.STRMEMNAME,
                 STRORDERCODE = rizeModel.STRORDERCODE,
                 STRPLANNO=rizeModel.STRPLANNO,
                 STRURL=rizeModel.STRURL,
            }};
            #endregion


            #region REQ赋值 
            Model.STOCK_AUTHORIZEModel stockModel = new Model.STOCK_AUTHORIZEModel();
            SetPropertyValue(headArr,stockModel);
            //
            SI_EC5_STOCK_AUTHORIZE.DT_EC5_WZERP_STOCK_AUTHORIZE_REQ iv = new SI_EC5_STOCK_AUTHORIZE.DT_EC5_WZERP_STOCK_AUTHORIZE_REQ();
            
            iv.BUSINESSTYPE = stockModel.BUSINESSTYPE;
            iv.MSGID = stockModel.MSGID;
            iv.STRSYSNUMBER = stockModel.STRSYSNUMBER;
            iv.STOCKAUTHORIZELIST = items;
            #endregion

            try
            {
                client.SI_EC5_STOCK_AUTHORIZE_REQ_A_OUT(iv);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Reflection;


namespace WZERP_E_BUSINESS.UserService
{
    //EC反馈采购总额处理结果到物装ERP服务接口定义
    public class PURCHASE_AMOUNTService:ServiceBase
    {
        //重写proxy
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_PURCHASE_AMOUNT.SI_EC5_PURCHASE_AMOUNT_RESP_A_OUTService();
        }

        public SI_WZERP_PURCHASE_AMOUNT.SI_EC5_PURCHASE_AMOUNT_RESP_A_OUTService client = null;
       
        //验证身份 
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_PURCHASE_AMOUNT.SI_EC5_PURCHASE_AMOUNT_RESP_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "服务创建出错："+ex.Message;
                return false;
            }
            return true;
        }

        //调用接口 
        public string TEST_PURCHASH_AMOUNT(string itemStr)
        {

            //itemStr =  "MSGID@_@123@__@STRSYSNUMBER@_@QH5800@__@STRMONTH@_@123@__@STANDCODE@_@123@__@RESULT@_@123@__@RESDESC@_@123";

            //参数赋值
            Model.PURCHASE_AMOUNTModel amountModel = new Model.PURCHASE_AMOUNTModel();
            var proInstance = amountModel.GetType();
            string[] itemArr = itemStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < itemArr.Length;i++ )
            {
                var tmpArr = itemArr[i].Split(new string[]{"@_@"},StringSplitOptions.None);
                foreach (PropertyInfo py in proInstance.GetProperties())
                {
                    if(py.Name.ToLower() == tmpArr[0].ToLower())
                    {
                        proInstance.GetProperty(py.Name).SetValue(amountModel, tmpArr[1]);
                    }
                }
            }

            //参数结构赋值
            SI_WZERP_PURCHASE_AMOUNT.DT_WZERP_EC5_PURCHASE_AMOUNT_RESPPURCHASEREQUESTS[] items = {new SI_WZERP_PURCHASE_AMOUNT.DT_WZERP_EC5_PURCHASE_AMOUNT_RESPPURCHASEREQUESTS(){
             RESDESC = amountModel.RESDESC,
              RESULT = amountModel.RESULT,
               STANDCODE = amountModel.STANDCODE,
                STRMONTH = amountModel.STRMONTH,
                } };
 
            //结构参数赋值
            SI_WZERP_PURCHASE_AMOUNT.DT_WZERP_EC5_PURCHASE_AMOUNT_RESP iv = new SI_WZERP_PURCHASE_AMOUNT.DT_WZERP_EC5_PURCHASE_AMOUNT_RESP();
            iv.STRSYSNUMBER = amountModel.STRSYSNUMBER; //QH5800 固定值 
            iv.MSGID = amountModel.MSGID;
            iv.PURCHASEREQUESTS = items.ToArray(); //结构赋值

            try
            {
                client.SI_EC5_PURCHASE_AMOUNT_RESP_A_OUT(iv);
                return "S";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }


        }
    }
}

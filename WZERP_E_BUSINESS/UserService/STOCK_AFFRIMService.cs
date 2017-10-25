using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS;
using System.Web.Services.Protocols;
using System.Reflection;

namespace WZERP_E_BUSINESS.UserService
{

    //EC采购方案到物装ERP集成接口服务接口定义
    public class STOCK_AFFRIMService:ServiceBase
    {
        //重写方法
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_STOCK_AFFRIM.SI_EC5_STOCK_AFFRIM_REQ_A_OUTService();
        }
        public SI_EC5_STOCK_AFFRIM.SI_EC5_STOCK_AFFRIM_REQ_A_OUTService client = null;

        //验证身份
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_STOCK_AFFRIM.SI_EC5_STOCK_AFFRIM_REQ_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }

        #region 调用接口
        public string TEST_STOCKE_AFFRIM(string headStr, string itemStr,string item1Str)
        {

            string[] headArr = headStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = itemStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            string[] item1Arr = item1Str.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            
            SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQ iv = new SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQ();

            #region STOCKAFFRIMMAT 赋值
            List<SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENTSTOCKAFFRIMMAT> mat_list = new List<SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENTSTOCKAFFRIMMAT>();
            SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENTSTOCKAFFRIMMAT matArr = new SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENTSTOCKAFFRIMMAT();

            for (var i = 0; i < item1Arr.Length; i++)
            {
                var tmpretArr = item1Arr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpretArr, matArr);
                mat_list.Add(matArr);
            }

            #endregion

            #region STOCKAFFRIMENT 赋值 
            List<SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENT> ment_list = new List<SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENT>();
            SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENT mentArr = new SI_EC5_STOCK_AFFRIM.DT_EC5_WZERP_STOCK_AFFRIM_REQSTOCKAFFRIMENT();
            mentArr.STOCKAFFRIMMAT=mat_list.ToArray();
            for (var i = 0; i < itemArr.Length; i++)
            {
                var tmpretArr = itemArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpretArr, mentArr);
                ment_list.Add(mentArr);
            }

            #endregion

            #region 参数结构赋值 
            SetPropertyValue(headArr, iv);
            iv.STOCKAFFRIMENT = ment_list.ToArray();
            
            #endregion 

            try
            {
                client.SI_EC5_STOCK_AFFRIM_REQ_A_OUT(iv);
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

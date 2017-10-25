using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Services.Protocols;
using System.Reflection;
using WZERP_E_BUSINESS;


namespace WZERP_E_BUSINESS.UserService
{
    public class ZQ_IF001Service:ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF001.SI_WZERP_ZQ_IF001_A_OUTService();
        }
        private SI_WZERP_ZQ_IF001.SI_WZERP_ZQ_IF001_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_ZQ_IF001.SI_WZERP_ZQ_IF001_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务错误:" + ex.Message;
                return false;
            }
            return true;
        }
        public string TEST_ZQ_IF001(string if001sep_Str,string if001erpfile_Str,string  if001erpproduct_Str)
        {
            string[] if001sepTmp = if001sep_Str.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] if001erpfileTmp = if001erpfile_Str.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            string[] if001erpproductTmp = if001erpproduct_Str.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
          
            
            SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQ iw = new SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQ();
            try
            {
                #region if001sep_Str information

                SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERP sepstr = new SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERP();
                SetPropertyValue(if001sepTmp, sepstr);
        
                #endregion
               
                #region if001erpfile_Str information

                List<SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPFILE> reqFile_list = new List<SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPFILE>();
                SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPFILE reqFileArr = new SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPFILE();

                for (var i = 0; i < if001erpfileTmp.Length; i++)
                {
                    var tmpretArr = if001erpfileTmp[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                    SetPropertyValue(tmpretArr, reqFileArr);//设置属性值
                    reqFile_list.Add(reqFileArr);
                }

                #endregion

                #region if001erpproduct_Str information

                List<SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPPRODUCTS> reqPrt_list = new List<SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPPRODUCTS>();
                SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPPRODUCTS reqPrtArr = new SI_WZERP_ZQ_IF001.DT_EC5_ZQ_IF001_REQAGREEMENTWZERPPRODUCTS();

                for (var i = 0; i < if001erpproductTmp.Length; i++)
                {
                    var tmpretArr = if001erpproductTmp[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                    SetPropertyValue(tmpretArr, reqPrtArr);//设置属性值
                    reqPrt_list.Add(reqPrtArr);
                }
                iw.AGREEMENTWZERP = sepstr;
                iw.AGREEMENTWZERPFILE = reqFile_list.ToArray() ;
                iw.AGREEMENTWZERPPRODUCTS = reqPrt_list.ToArray();
                #endregion
            }
            catch (Exception ex)
            {
                return "数据预处理错误:" + ex.Message + ex.Source;
            }

          
            try
            {
                client.SI_WZERP_ZQ_IF001_A_OUT(iw);
                return "S";
            }
            catch (Exception ex)
            {
                return "程序报错!" + ex.Message + ex.Source;
            }
        }
    }
}

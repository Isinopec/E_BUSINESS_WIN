using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS;

namespace WZERP_E_BUSINESS.UserService
{
    public class SI_EC5_DISPATCH_SO_REQ_DJZService:ServiceBase
    {
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_EC5_DISPATCH_SO_REQ_DJZ.SI_EC5_DISPATCH_SO_REQ_DJZ_A_OUTService();
        }
        private SI_EC5_DISPATCH_SO_REQ_DJZ.SI_EC5_DISPATCH_SO_REQ_DJZ_A_OUTService client = null;
        public bool CreateService()
        {
            try
            {
                client = (SI_EC5_DISPATCH_SO_REQ_DJZ.SI_EC5_DISPATCH_SO_REQ_DJZ_A_OUTService)this.CreateSoapProxy();
            }
            catch (Exception ex)
            {
                var msg = "创建服务错误:" + ex.Message;
                return false;
            }
            return true;
        }
        public string test_Dispatch(string headstr,string Transarg)
        {
            string[] headArr = headstr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);
            string[] traArr=Transarg.Split(new string[] {"#_#"},StringSplitOptions.RemoveEmptyEntries);

            SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARG Itr=new SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARG();
            try
            {
                List<SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARGTRANSARGMAT> mat_list=new List<SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARGTRANSARGMAT>();
                SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARGTRANSARGMAT matArr=new SI_EC5_DISPATCH_SO_REQ_DJZ.TRANSARGTRANSARGMAT();
                for(int i =0;i<traArr.Length;i++)
                {
                    string[] tmpArr=Transarg.Split(new string[] {"@__@"},StringSplitOptions.RemoveEmptyEntries);
                    SetPropertyValue(tmpArr,matArr);
                    mat_list.Add(matArr);

                }
                SetPropertyValue(headArr, Itr);
                Itr.TRANSARGMAT=mat_list.ToArray();

                try
                {
                    client.SI_EC5_DISPATCH_SO_REQ_DJZ_A_OUT(Itr);
                    return "S";
                }
                catch (Exception ex)
                {
                    return "程序报错!" + ex.Message + ex.Source;
                }
            }
            catch (Exception ex)
            {
                return "程序报错!" + ex.Message + ex.Source;
            }
            
        }
    }
}

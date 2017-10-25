using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Net;

namespace WZERP_E_BUSINESS
{
    //用户验证
    public abstract class ServiceBase
    {
        protected abstract SoapHttpClientProtocol InstanceProxy();
        protected virtual SoapHttpClientProtocol CreateSoapProxy()
        {
            string RfcUsername = "RFCATUSER";
            string RfcPassword = "q123456";
            SoapHttpClientProtocol proxy = InstanceProxy();
            proxy.Timeout = 1000 * 60 * 5;
            proxy.Credentials = new NetworkCredential(RfcUsername,RfcPassword);
            return proxy;
        }

        #region property赋值 

        public void SetPropertyValue(string[] arrObj,object modelObj)
        {

            var modelInstance = modelObj.GetType();
            for (var i = 0; i < arrObj.Length; i++)
            {
                var tmpArr = arrObj[i].Split(new string[] { "@_@" }, StringSplitOptions.None);
                foreach ( System.Reflection.PropertyInfo py in modelInstance.GetProperties())
                {
                    if (py.Name.ToLower() == tmpArr[0].ToLower())
                    {
                        modelInstance.GetProperty(py.Name).SetValue(modelObj, tmpArr[1]);
                    }
                }
            }
        }

        

        #endregion

    }
}

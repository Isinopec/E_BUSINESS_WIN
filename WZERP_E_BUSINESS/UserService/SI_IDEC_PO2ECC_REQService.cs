using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.UserService
{
    public class SI_IDEC_PO2ECC_REQService:ServiceBase
    {
        //重写InstanceProxy创建soap协议
        protected override System.Web.Services.Protocols.SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_IDEC_PO2ECC_REQ_A.SI_IDEC_PO2ECC_REQ_A_OUTService();
        }

        public SI_IDEC_PO2ECC_REQ_A.SI_IDEC_PO2ECC_REQ_A_OUTService client = null;

        //创建服务
        public bool CreateService()
        {
            try
            {
                client = (SI_IDEC_PO2ECC_REQ_A.SI_IDEC_PO2ECC_REQ_A_OUTService)this.CreateSoapProxy();
                return true;
            }
            catch (Exception ex)
            {
                var msg = "创建服务出错" + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// 采购订单（含电子超市与专业市场）上传
        /// </summary>
        /// <param name="pohStr"></param>
        /// <param name="polStr"></param>
        /// <returns></returns>
        public string Test_PO2ECC(string pohStr, string polStr)
        {
            string[] pohArr = pohStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);
            string[] polArr = polStr.Split(new string[] { "#_#" }, StringSplitOptions.RemoveEmptyEntries);


            #region POH 赋值
            List<SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOH> pohList = new List<SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOH>();
            for (var i = 0; i < pohArr.Length; i++)
            {
                SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOH pohModel = new SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOH();

                var tmpArr = pohArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpArr, pohModel);//设置属性值

                pohList.Add(pohModel);
            }

            #endregion

            #region POl 赋值
            List<SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOL> polList = new List<SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOL>();
            for (var i = 0; i < polArr.Length; i++)
            {
                SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOL polModel = new SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQIT_ZMROSZYSCPOL();

                var tmpArr = polArr[i].Split(new string[] { "@__@" }, StringSplitOptions.None);
                SetPropertyValue(tmpArr, polModel);//设置属性值

                polList.Add(polModel);
            }
            #endregion

            SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQ reqModel = new SI_IDEC_PO2ECC_REQ_A.DT_IDEC_PO2ECC_REQ();
            reqModel.IT_ZMROSZYSCPOH = pohList.ToArray();
            reqModel.IT_ZMROSZYSCPOL = polList.ToArray();

            try
            {
                client.SI_IDEC_PO2ECC_REQ_A_OUT(reqModel);
                return "S";
            }
            catch (Exception Ex)
            {
                var msg = "程序调用出错，请检查参数是否正确：" + Ex.Message;
                return msg;
            }

        }
    }
}

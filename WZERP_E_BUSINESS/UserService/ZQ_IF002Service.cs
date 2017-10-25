using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace WZERP_E_BUSINESS.UserService
{
    //
    public class ZQ_IF002Service:ServiceBase
    {
        protected override SoapHttpClientProtocol InstanceProxy()
        {
            return new SI_WZERP_ZQ_IF002.SI_WZERP_ZQ_IF002_A_OUTService();
        }
        public SI_WZERP_ZQ_IF002.SI_WZERP_ZQ_IF002_A_OUTService client = null;

        //
        public bool CreateService()
        {
            try
            {
                client = (SI_WZERP_ZQ_IF002.SI_WZERP_ZQ_IF002_A_OUTService)this.CreateSoapProxy();
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
            return true;
        }

        //
        public string TEST_ZQ_IF002(string headStr, string itemStr)
        {
            string[] headArr = headStr.Split(new string[]{"@__@"},StringSplitOptions.RemoveEmptyEntries);
            string[] itemArr = itemStr.Split(new string[] { "@__@" }, StringSplitOptions.RemoveEmptyEntries);

            #region//ART赋值 
            Model.ZQ_IF002_SUPP suppModel = new Model.ZQ_IF002_SUPP();
            SetPropertyValue(headArr, suppModel);

            SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQSTOCKAFFIRMSUPPPART[] ART = { new SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQSTOCKAFFIRMSUPPPART(){
                 ITEMNO=suppModel.ITEMNO,
                 STOCKORDER=suppModel.STOCKORDER,
                 SUPPCODE = suppModel.SUPPCODE,
            }};

            #endregion

            #region SUP赋值 
            Model.ZQ_IF002Model supModel = new Model.ZQ_IF002Model();
            SetPropertyValue(itemArr, supModel);
            SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQSTOCKAFFIRMSUPP SUP = new SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQSTOCKAFFIRMSUPP();
                 SUP.COMPORG=supModel.COMPORG;
                 SUP.MSGID=supModel.MSGID;
                 SUP.SENDTIME=supModel.SENDTIME;
                 SUP.STOCKAFFIRM = supModel.STOCKAFFIRM;
                 SUP.STRN = supModel.STRN;
                 
            
            #endregion

            SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQ iv = new SI_WZERP_ZQ_IF002.DT_EC5_ZQ_IF002_REQ();
            iv.STOCKAFFIRMSUPP = SUP;
            iv.STOCKAFFIRMSUPPPART = ART;

            try
            {
                client.SI_WZERP_ZQ_IF002_A_OUT(iv);
                return "S";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
       
    }
}

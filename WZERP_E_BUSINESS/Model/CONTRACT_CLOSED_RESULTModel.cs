using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    public class CONTRACT_CLOSED_RESULTModel
    {
        public string MSGID { set; get; }
        public string RESDESC { set; get; }
        public string RESTIME { set; get; }
        public string RESULT { set; get; }
        public string STRSYSNUMBER { set; get; }
        public string VBELN { set; get; }

    }

    public class CONTRACTITEMRESULTModel
    {
      
        public string INVOICEITEM { set; get; }
        public string RESDESC { set; get; }

    }

}

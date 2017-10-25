using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    public class PAY_CONTRACT_RESPmodel
    {

        public string MSGID { get; set; }
        public string RESULT { get; set; }
        public string RESTIME { get; set; }
        public string RESDESC { get; set; }
        public string EBELN { get; set; }

        public string STRSYSNUMBER { get; set; }
    }

    public class CONTRACTITEMRESULTTmodel
    {
        public string ITEMNO { get; set; }
        public string RESDESC { get; set; }
    }
}

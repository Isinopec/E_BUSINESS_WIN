using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    public class CONTRACT_PAID_RESULTmodel
    {
        public string MSGID { get; set; }
        public string RESULT { get; set; }
        public string RESTIME { get; set; }
        public string RESDESC { get; set; }
        public string VBELN { get; set; }
        public string STRSYSNUMBER { get; set; }
    }

    public class CONTRACTITEMRESULTmodel
    {
        public string INVOICEITEM { get; set; }
        public string RESDESC { get; set; }
    }





}

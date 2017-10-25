using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZERP_E_BUSINESS.SI_EC5_LOGISTICS_INFO_RESULT;

namespace WZERP_E_BUSINESS.Model
{
    public class LOGISTICS_INFO_RESULTModel
    {
        public string MSGID { get; set; }

        public string STRSYSNUMBER { get; set; }

        public string SENDTIME { get; set; }

    }

    public class LOGISTICS_INFO_RESULTMATModel
    {

        public string ZZHTBH { get; set; }

        public string VGBEL { get; set; }

        public string VBPOS { get; set; }

        public string VBELN { get; set; }

        public string POSNR { get; set; }

        public string ECORDERCODE { get; set; }

        public string RESULT { get; set; }

        public string RESTIME { get; set; }

        public string RESDESC { get; set; }
    }
}

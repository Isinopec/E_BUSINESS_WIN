using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    //STOCKAFFIRM
    public class ZQ_IF002Model
    {
        public string MSGID { get; set; }

        public string STRN { get; set; }

        public string COMPCODE { get; set; }

        public string COMPORG { get; set; }

        public string STOCKAFFIRM { get; set; }

        public string SENDTIME { get; set; }
    }

    //STOCKAFFIRMSUPPPART
    public class ZQ_IF002_SUPP
    {
        public string ITEMNO { get; set; }

        public string STOCKORDER { get; set; }

        public string SUPPCODE { get; set; }
    }

}

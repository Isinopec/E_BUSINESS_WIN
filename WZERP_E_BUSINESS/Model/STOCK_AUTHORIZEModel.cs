using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{

    //STOCK_AUTHORIZE_REQ 实体
    public class STOCK_AUTHORIZEModel
    {
        public string MSGID { get; set; }
        public string STRSYSNUMBER { get; set; }
        public string BUSINESSTYPE { get; set; }

        //private DT_EC5_WZERP_STOCK_AUTHORIZE_REQSTOCKAUTHORIZELIST[] sTOCKAUTHORIZELISTField;
    }

    //STOCKAUTHORIZELIST 实体 
    public class STOCKAUTHORIZELIST
    {
        public string STRORDERCODE { get; set; }

        public string PZWT_NO { get; set; }

        public string INTTYPE { get; set; }

        public string INTCODE_TRAN { get; set; }

        public string INTCODE_TO { get; set; }

        public string STRMEMNAME { get; set; }

        public string DASUBTIME { get; set; }

        public string INTATTRTYPE { get; set; }

        public string INTFLAG { get; set; }

        public string STRPLANNO { get; set; }

        public string STRURL { get; set; }

        public string DALEADTIME { get; set; }

        public string INTCOCODE { get; set; }
    }



}

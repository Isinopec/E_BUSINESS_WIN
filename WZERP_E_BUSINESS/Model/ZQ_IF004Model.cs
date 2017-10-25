using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    public class ZQ_IF004_AGREEMENTWZERPCHGModle
    {
       /* public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG aGREEMENTWZERPCHG { get; set; }

        public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] aGREEMENTWZERPCHGFILE { get; set; }

        public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] aGREEMENTWZERPCHGPRODUCTS { get; set; }*/
        public string mSGID { get; set; }

        public string sTRN { get; set; }

        public string sENDTIME { get; set; }

        public string sTARTDATE { get; set; }

        public string eNDDATE { get; set; }

        public string tARGETVALUE { get; set; }

        public string sTOCKTYPE { get; set; }

        public string aTTRTYPE { get; set; }

        public string aGRCODE { get; set; }

        public string oPERATETYPE { get; set; }

        public string sAPAGRCODE { get; set; }

        public string mODIFYCODE { get; set; }

        public string xGYY { get; set; }

        public string bGNR { get; set; }

        public string yL1 { get; set; }

        public string yL2 { get; set; }

        public string yL3 { get; set; }

        public string yL4 { get; set; }

        public string yL5 { get; set; }
    }
    public class ZQ_IF004_AGREEMENTWZERPCHGFILEModle
    {
        /* public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG aGREEMENTWZERPCHG { get; set; }

         public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] aGREEMENTWZERPCHGFILE { get; set; }

         public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] aGREEMENTWZERPCHGPRODUCTS { get; set; }*/
        public string aGRCODE { get; set; }

        public string iTEMNO { get; set; }

        public string fILECODE { get; set; }

        public string fILENAME { get; set; }

        public string fILETYPE { get; set; }

        public string fILEURL { get; set; }

        public string yL1 { get; set; }
    }

    public class ZQ_IF004_AGREEMENTWZERPCHGPRODUCTSModle
    {
        /* public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG aGREEMENTWZERPCHG { get; set; }

         public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] aGREEMENTWZERPCHGFILE { get; set; }

         public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] aGREEMENTWZERPCHGPRODUCTS { get; set; }*/
        public string aGRCODE { get; set; }

        public string iTEMNO { get; set; }

        public string pRODNAME { get; set; }

        public string pRODCLASS { get; set; }

        public string qUANTITY { get; set; }

        public string uNIT { get; set; }

        public string pRICE { get; set; }

        public string tAXCODE { get; set; }

        public string yL1 { get; set; }

        public string yL2 { get; set; }

        public string yL3 { get; set; }

        public string yL4 { get; set; }

        public string yL5 { get; set; }
    }
}

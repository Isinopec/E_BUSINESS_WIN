using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    class BID_REFUNDModel
    {
        public string MSGID { get; set; }
        public string SYSNUMER { get; set; }
        public string COMPANY { get; set; }
        public string REFUNDREQNUM { get; set; }
        public string BIDCONSIGN { get; set; }
        public string BIDFILECODE { get; set; }
        public string ITEMCODE { get; set; }
        public string ITEMNAME { get; set; }
        public string OPERATETYPE { get; set; }
        public string REFUNDTYPE { get; set; }
        public string STRZBBM { get; set; }
        public string STRCORPNAME { get; set; }
        public string CURRENCY { get; set; }
        public string RATE { get; set; }
        public string ACCOUNTNAME { get; set; }
        public string BANKNAME { get; set; }
        public string ACCOUNTNUM { get; set; }
        public string REALNAME { get; set; }
        public string ZZFPT { get; set; }

        //public BIDREFUNDMAT[] BIDREFUNDMAT { get; set; }

    }

    public class BIDREFUNDMAT
    {
        public string LINEITEM { get; set; }
        public string PACKCODE { get; set; }
        public string AMOUNT { get; set; }
        public string PAYEDMONEY { get; set; }
        public string REMARK { get; set; }

        //public VOUCHER[] VOUCHER { get; set; }
    }

    public class VOUCHER
    {
        public string VOUCHERNO { get; set; }
        public string VOUCHERYEAR { get; set; }
    }
}

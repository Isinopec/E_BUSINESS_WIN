using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZERP_E_BUSINESS.Model
{
    public class ZQIF006_RESPmodel
    {
        //消息唯一标识
        public string MSGID { get; set; }
        //系统标识
        public string STRN { get; set; }
        //发送时间
        public string SENDTIME { get; set; }
        //消息类型: S 成功,E 错误
        public string AGRRESULT { get; set; }
        //消息文本
        public string AGRRESDESC { get; set; }
    }
    
}

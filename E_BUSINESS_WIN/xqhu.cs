using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WZERP_E_BUSINESS;
using WZERP_E_BUSINESS.UserService;

namespace E_BUSINESS_WIN
{
    public partial class xqhu : Form
    {
        public xqhu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strItem = "MSGID@_@1@_@@__@STRN@_@QH5800@_@@__@SENDTIME@_@123@_@@__@AGRRESULT@_@S@_@@__@AGRRESDESC@_@成功@_@@__@";
            ZQIF006_RESPService agent = new ZQIF006_RESPService();

            if (agent.CreateService())
            {
                agent.TEST_ZQIF006RESP(strItem);

            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strRes = "MSGID@_@1@_@@__@STRSYSNUMBER@_@QH5800@_@@__@SENDTIME@_@123@_@@__@";
            string strResmat = "ZZHTBH@_@5@_@@__@VGBEL@_@6@_@@__@VBPOS@_@5@_@@__@VBELN@_@44@_@@__@POSNR@_@66@_@@__@ECORDERCODE@_@78@_@@__@RESULT@_@1@_@@__@RESTIME@_@20170814@_@@__@RESDESC@_@S@_@@__@";

            LOGISTICS_INFO_RESULTService Logagent = new LOGISTICS_INFO_RESULTService();


            if (Logagent.CreateService())
            {
                var n = Logagent.TEST_LOGISTICS_INFO_RESULT(strRes, strResmat);
                MessageBox.Show(n);
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }

        }


        private void xqhu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strrequest = "MSGID@_@123@_@@__@STRSYSNUMBER@_@QH5800@_@@__@BUSINESSTYPE@_@XI@_@@__@";
            string strreqphre = "STRORDERCODE@_@23434222@_@@__@STRCORPNAME@_@321@_@@__@STRPLANNO@_@54000032110@_@@__@STRPROJECTNO@_@WZIT@_@@__@STRPRODCODE@_@6050378797998200@_@@__@STRPRODNAME@_@WLAWSDASD@_@@__@INTQTY@_@10@_@@__@STRUNIT@_@TO@_@@__@STRSTANDARD@_@BZ@_@@__@INTBUDGETARY@_@1000@_@@__@DACONTIME@_@20170814@_@@__@STRCONADDR@_@1002@_@@__@STRMEMNAME@_@NB@_@@__@STRMATERTYPE@_@DES@_@@__@STRUSERID@_@ATMMUSER@_@@__@DASUBTIME@_@20170815@_@@__@STRURL@_@URL@_@@__@STRPROJECTNM@_@WZ@_@@__@STREQUIPNM@_@SG@_@@__@STRLOCATION@_@2@_@@__@STRDRAW@_@5@_@@__@STRPIECE@_@4@_@@__@STRSTANDALONE@_@4@_@@__@STRAPPLY@_@10@_@@__@STRHEAT@_@100@_@@__@STRRECEIVER@_@1001@_@@__@NMATKL@_@A1@_@@__@STRMARK@_@bz@_@@__@ZBDBZ@_@wlbd@_@@__@DAPLANTIME@_@20170815@_@@__@STRSYSNUMBER@_@QH5800@_@@__@";

            SI_EC5_WZERP_PR_REQService Reagent = new SI_EC5_WZERP_PR_REQService();

            if (Reagent.CreateService())
            {
                var re = Reagent.TEST_WZERP_PR_REQ(strrequest, strreqphre);
                MessageBox.Show(re);
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string head = "GUID@_@131@__@INTERFACE_ID@_@132@__@MANDT@_@133@__@OPERATOR@_@134@__@PROXY_ID@_@135@__@RECIVER@_@136@__@SENDER@_@137@__@SENDTIME@_@138@__@SPRAS@_@139@__@SYSTEM_ID@_@140";
            string dditem = "EBELP@_@111@__@EINDT@_@112@__@KONNR@_@113@__@MATNR@_@114@__@MEINS@_@115@__@MENGE@_@116@__@MWSKZ@_@117@__@NETPR@_@118@__@VBELN@_@119@__@VBELP@_@120@__@WAERS@_@121@__@ZZEPECSN@_@122@__@ZZYL1@_@123@__@ZZYL2@_@124@__@ZZYL3@_@125@__@ZZYL4@_@126@__@ZZYL5@_@127@__@ZZYL6@_@128@__@ZZYL7@_@129@__@ZZYL8@_@130";
            string nxjh = "DAOPT@_@141@__@ERDAT@_@142@__@INTSTATUS2@_@143@__@ISPO@_@144@__@LOGSYS@_@QH5800@__@STRCONTIME@_@146@__@STRMEMLOGNAME@_@147@__@STRSUBTIME@_@148@__@URNAM@_@149@__@USEFLAG@_@150@__@ZKUUNR@_@151@__@ZZEPECID@_@152@__@ZZEPECLN@_@153@__@LIFNR@_@154@__@ZZEPECLNSO@_@155@__@ZZEPECSN@_@156@__@ZZEPECSNSO@_@157@__@ZZHTLB@_@158@__@ZZINTATTRTYPE@_@159@__@ZZKHSX@_@160@__@ZZMANAMODE@_@161@__@ZZXXH@_@162@__@ZZYF@_@163@__@ZZYL1@_@164@__@ZZZFFSBM@_@165@__@ZZYL2@_@166@__@ZZYL3@_@167@__@ZZYL4@_@168@__@ZZYL5@_@169@__@ZZYL6@_@170@__@ZZYL7@_@171@__@ZZYL8@_@172";

            SI_EPEC_CRT_ORDER_REQService agent = new SI_EPEC_CRT_ORDER_REQService();

            if (agent.CreateService())
            {
                var TT = agent.Test_CRT_ORDER_REQ(head, dditem, nxjh);
                MessageBox.Show(TT);
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }
    }
}

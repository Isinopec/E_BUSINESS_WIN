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


//using WZERP_E_BUSINESS.SI_WZERP_AGREEMENT_TEXT_RESULT;

namespace E_BUSINESS_WIN
{
    public partial class xychen: Form
    {
        public xychen()
        {
            InitializeComponent();
        }

        private void CXY_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ENTStr = "AGRCODE@_@001DA@__@AGRCONTRACTCODE@_@002DA@__@AGREETYPE@_@003DA@__@AGRNAME@_@004DA@__@AGRPROJCODE@_@005DA@__@AGRVERSION@_@006DA@__@ATTACHMENTURL@_@007DA@__@ATTRTYPE@_@008DA@__@BIDCODE@_@009DA@__@CREATECORP@_@010DA@__@CREATEDEPT@_@011DA@__@CURRENCY@_@012DA@__@ENDDATE@_@013DA@__@INTTYPE@_@014DA@__@MSGID@_@015DA@__@PROJCODE@_@016DA@__@REMARKTEXT@_@017DA@__@SAVINGRATE@_@018DA@__@SENDTIME@_@019DA@__@SIGNDATE@_@020DA@__@SIGNSUPP@_@021DA@__@SIGNSUPPNAME@_@022DA@__@SIGNTYPE@_@023DA@__@SIGNUSER@_@024DA@__@STARTDATE@_@025DA@__@STOCKAFFCODE@_@026DA@__@STOCKTYPE@_@027DA@__@STRN@_@QH5800@__@SUBTIME@_@029DA@__@SUPPQUOTA@_@030DA@__@TARGETVALUE@_@031DA@__@TAXRATE@_@032DA";
            string ENTentStr = "CORPAMOUNT@_@034DA@__@CORPCODE@_@035DA@__@CORPNAME@_@036DA@__@CORPTARGETVALUE@_@037DA@__@CORPTYPE@_@038DA@__@ERPFACTORY@_@qwerDA@__@ERPFACTORYNAME@_@040DA@__@ERPGROUP@_@041DA@__@ERPGROUPNAME@_@042DA@__@ERPORG@_@043DA";
            string ENTMatStr = "AVGPRICE@_@045@__@ERPUNIT@_@046DA@__@ITEMNO@_@047DA@__@ITEMTYPE@_@048DA@__@PRICE@_@049@__@PRODCLASS@_@050DA@__@PRODCODE@_@051DA@__@PRODNAME@_@052DA@__@QUANTITY@_@1@__@UNIT@_@054D";

            WZERP_E_BUSINESS.UserService.AGREEMENTService agent = new WZERP_E_BUSINESS.UserService.AGREEMENTService();
            if (agent.CreateService())
            {
                var wer = agent.TEST_Agreement(ENTStr, ENTentStr, ENTMatStr);
                MessageBox.Show(wer);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string itemStr = "F_BYMXZD1@_@1qaz@__@IV_EBELN@_@2wsx@__@IV_STATUS@_@3edc@__@IV_ZTYPE@_@4rfv@__@IV_ZZID@_@5tgb@__@MSGID@_@6yhn@__@SYSNUMER@_@QH5800";

            WZERP_E_BUSINESS.UserService.AGREEMENT_TEXT_RESULTService agent = new WZERP_E_BUSINESS.UserService.AGREEMENT_TEXT_RESULTService();
            if (agent.CreateService())
            {
                var wer = agent.TEST_AGREEMENT_TEXT_RESULT(itemStr);
                MessageBox.Show(wer);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WZERP_E_BUSINESS.UserService.ZQ_IF001Service agent = new WZERP_E_BUSINESS.UserService.ZQ_IF001Service();
            if (agent.CreateService())
            {

                string if001str = "MSGID@_@00100@_@@__@STRN@_@QH5800@_@@__@SENDTIME@_@00102@_@@__@SIGNSUPP@_@00103@_@@__@AGREETYPE@_@00104@_@@__@SIGNDATE@_@00105@_@@__@CREATECORP@_@00106@_@@__@STARTDATE@_@00107@_@@__@ENDDATE@_@00108@_@@__@TARGETVALUE@_@00109@_@@__@STOCKTYPE@_@00110@_@@__@ATTRTYPE@_@11@_@@__@AGRCODE@_@00112@_@@__@OPERATETYPE@_@00113@_@@__@SAPAGRCODE@_@00114@_@@__@OPERATEDEPT@_@00115@_@@__@CREATEUSERNAME@_@00116@_@@__@CREATECOMPNAME@_@00117@_@@__@USERTELEPHONE@_@00118@_@@__@BIDFILECODE@_@00119@_@@__@BIDPACKNO@_@00120@_@@__@BIDPROJECTNAME@_@00121@_@@__@AGREEMENTNAME@_@00122@_@@__@BIDNOTIFYTIME@_@00123@_@@__@YL1@_@00124@_@@__@YL2@_@00125@_@@__@YL3@_@00126@_@@__@YL4@_@00127@_@@__@YL5@_@00128@_@@__@";
                string if001erpfilestr = "AGRCODE@_@00130@_@@__@ITEMNO@_@00131@_@@__@FILECODE@_@00132@_@@__@FILENAME@_@00133@_@@__@FILETYPE@_@00134@_@@__@FILEURL@_@00135@_@@__@YL1@_@00136@_@@__@";
                string if001erpprostr = "AGRCODE@_@00138@_@@__@ITEMNO@_@00139@_@@__@PRODNAME@_@00140@_@@__@PRODCLASS@_@00141@_@@__@QUANTITY@_@00142@_@@__@UNIT@_@00143@_@@__@PRICE@_@00144@_@@__@TAXCODE@_@00145@_@@__@YL1@_@00146@_@@__@YL2@_@00147@_@@__@YL3@_@00148@_@@__@YL4@_@00149@_@@__@YL5@_@00150@_@@__@";
                var wer = agent.TEST_ZQ_IF001(if001str, if001erpfilestr, if001erpprostr);
                MessageBox.Show(wer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WZERP_E_BUSINESS.UserService.STOCK_AFFRIMService agent = new WZERP_E_BUSINESS.UserService.STOCK_AFFRIMService();
            if (agent.CreateService())
            {
                string headstr = "MSGID@_@1@__@STRSYSNUMBER@_@QH5800@__@BUSINESSTYPE@_@2@__@R_NO@_@3@__@BUKRS@_@4@__@PURORG@_@5@__@ERFQ_NO@_@6@__@BEDAT@_@7@__@AGDAT@_@8@__@CGFS@_@9@__@ERFQ_TOPIC@_@10@__@STRMEMNAME@_@11@__@DASENDTIME@_@12";
                string itmstr1 = "VENDOR_NO@_@14@__@ERDAT@_@15@__@ZZB@_@16@__@STRENQUTYPE@_@17@__@STRURL@_@18";
                string itmstr2 = "PR_NO@_@20@__@PRICE@_@21@__@TRANSPORT_FEE@_@22@__@OTHER_FEE@_@23@__@CGLX@_@24@__@STRTAX@_@25@__@INTQTY@_@26@__@ZCGBZ@_@27@__@STRORDERCODE@_@28@__@DACONTIME@_@29";
                var wer = agent.TEST_STOCKE_AFFRIM(headstr, itmstr1, itmstr2);
                MessageBox.Show(wer);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WZERP_E_BUSINESS.UserService.SI_WZERP_PAYBACK_RESULTService agent = new WZERP_E_BUSINESS.UserService.SI_WZERP_PAYBACK_RESULTService();
            if (agent.CreateService())
            {
                string headstr = "SYSTEM_ID@_@1000@__@SPRAS@_@1@__@SENDTIME@_@20170809@__@SENDER@_@1@__@RECIVER@_@2@__@PROXY_ID@_@3@__@OPERATOR@_@4@__@MANDT@_@5@__@INTERFACE_ID@_@6@__@GUID@_@7";
                string itmstr1 = "ZZYL8@_@A@__@ZZYL7@_@B@__@ZZYL6@_@C@__@ZZYL5@_@ATSDUSER@__@ZZYL4@_@D@__@ZZYL3@_@E@__@ZZYL2@_@F@__@ZZYL1@_@G@__@ZZXXH@_@11@__@ZZXTBS@_@12@__@ZZEPECSN@_@13@__@ZZEPECLN@_@14@__@ZZEPECID@_@15@__@ZZCLSJ@_@16@__@ZZCLRQ@_@17@__@ZLOG@_@18@__@VBELN@_@19@__@RPREGNO@_@20@__@LOGSYS@_@QH5800";
                var wer = agent.Test_WZERP_PAYBACK_RESULT(headstr, itmstr1);
                MessageBox.Show(wer);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WZERP_E_BUSINESS.UserService.SI_EC5_DISPATCH_SO_REQ_DJZService agent = new WZERP_E_BUSINESS.UserService.SI_EC5_DISPATCH_SO_REQ_DJZService();
            if (agent.CreateService())
            {
                string headstr = "TRANSORDERCODE@_@11@__@SUBTIME@_@0.791678240740741@__@STRSYSNUMBER@_@TR4800@__@MSGID@_@13@__@KUNNR@_@14@__@ERPPONO@_@15@__@ERPORG@_@16@__@ERPGROUP@_@17@__@ERPFACTORY@_@18@__@ECORDERCODE@_@19@__@CREATEUSER@_@ATMMUSER@__@CORPCODE@_@21@__@BUKRS@_@1590";
                string itmstr = "ITEMNO@_@50@__@PRODCODE@_@51@__@NETPR@_@52@__@MWSKZ@_@53@__@MENGE@_@54@__@MEINS@_@55@__@LGORT@_@56@__@EINDT@_@57@__@ECORDERCODE@_@58@__@CHARG@_@59";
                var wer = agent.test_Dispatch(headstr, itmstr);
                MessageBox.Show(wer);
            }
        }
    }
}

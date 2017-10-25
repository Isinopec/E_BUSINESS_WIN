using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BUSINESS_WIN
{
    public partial class xpli : Form
    {
        public xpli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemStr = "YL5@_@BJ1701@__@YL4@_@BJ1701@__@YL3@_@BJ1701@__@YL2@_@BJ1701@__@YL1@_@BJ1701@__@OPERATETYPE@_@BJ1701@__@MODIFYCODE@_@BJ1701@__@SAPAGRCODE@_@BJ1701@__@AGRCODE@_@BJ1701@__@OPERATEDATE@_@BJ1701@__@OPERATEUSER@_@BJ1701@__@AGRSTATUS@_@BJ1701@__@SENDTIME@_@BJ1701@__@STRN@_@QH5800@__@MSGID@_@BJ1701@__@";
            WZERP_E_BUSINESS.UserService.ZQ_IF003Service agent = new WZERP_E_BUSINESS.UserService.ZQ_IF003Service();

            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_ZQ_IF003(itemStr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Stritemstr1 = "YL5@_@1701@__@YL4@_@1701@__@YL3@_@1701@__@YL2@_@1701@__@YL1@_@1701@__@BGNR@_@1701@__@XGYY@_@1701@__@MODIFYCODE@_@1701@__@SAPAGRCODE@_@1701@__@OPERATETYPE@_@1701@__@AGRCODE@_@1701@__@ATTRTYPE@_@1701@__@STOCKTYPE@_@1701@__@TARGETVALUE@_@1701@__@ENDDATE@_@1701@__@STARTDATE@_@1701@__@SENDTIME@_@1701@__@STRN@_@QH5800@__@MSGID@_@1701";
            WZERP_E_BUSINESS.UserService.ZQ_IF004Service agent = new WZERP_E_BUSINESS.UserService.ZQ_IF004Service();
            string Stritemstr2 = "YL1@_@1701@__@FILEURL@_@1701@__@FILETYPE@_@1701@__@FILENAME@_@1701@__@FILECODE@_@1701@__@ITEMNO@_@1701@__@AGRCODE@_@1701";
            string Stritemstr3 = "YL5@_@1701@__@YL4@_@1701@__@YL3@_@1701@__@YL2@_@1701@__@YL1@_@1701@__@TAXCODE@_@1701@__@PRICE@_@1701@__@UNIT@_@1701@__@QUANTITY@_@1701@__@PRODCLASS@_@1701@__@PRODNAME@_@1701@__@ITEMNO@_@1701@__@AGRCODE@_@1701";
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_ZQ_IF004(Stritemstr1, Stritemstr2, Stritemstr3);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Stritemstr1 = "YL5@_@1701@__@YL4@_@1701@__@YL3@_@1701@__@YL2@_@1701@__@YL1@_@1701@__@OPERATETYPE@_@1701@__@MODIFYCODE@_@1701@__@SAPAGRCODE@_@1701@__@AGRCODE@_@1701@__@XGYY@_@1701@__@SENDTIME@_@1701@__@STRN@_@QH5800@__@MSGID@_@1701";
            WZERP_E_BUSINESS.UserService.ZQ_IF005Service agent = new WZERP_E_BUSINESS.UserService.ZQ_IF005Service();

            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_ZQ_IF005(Stritemstr1);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Stritemstr1 = "SENDTIME@_@BJ1701@__@RECIVER@_@BJ1701@__@SENDER@_@BJ1701@__@INTERFACE_ID@_@BJ1701@__@SPRAS@_@BJ1701@__@OPERATOR@_@BJ1701@__@SYSTEM_ID@_@BJ1701@__@PROXY_ID@_@BJ1701@__@GUID@_@BJ1701@__@MANDT@_@BJ1701";
            string Stritemstr2 = "ZZYL8@_@BJ1701@__@ZZYL7@_@BJ1701@__@ZZYL6@_@BJ1701@__@ZZYL5@_@BJ1701@__@ZZYL4@_@BJ1701@__@ZZYL3@_@BJ1701@__@ZZYL2@_@BJ1701@__@ZZYL1@_@BJ1701@__@MBLNR@_@BJ1701@__@ZZDZCGHTH@_@BJ1701@__@ZZHTBH@_@BJ1701@__@EBELN@_@BJ1701@__@ZLOG@_@BJ1701@__@ZCGBZ@_@BJ1701@__@MSGID@_@BJ1701@__@ZZEPECID@_@BJ1701@__@ZZEPECSN@_@BJ1701@__@ZZEPECLN@_@BJ1701@__@LOGSYS@_@BJ1701@__@ZZXXH@_@BJ1701";
            WZERP_E_BUSINESS.UserService.SI_EPEC_DO_POST_RESPService agent = new WZERP_E_BUSINESS.UserService.SI_EPEC_DO_POST_RESPService();

            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_POST_RESP(Stritemstr1, Stritemstr2);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

       
    }
}

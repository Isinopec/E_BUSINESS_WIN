using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WZERP_E_BUSINESS.UserService;
namespace E_BUSINESS_WIN
{
    public partial class ccye : Form
    {
        public ccye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strHeader = "INVOICEITEM@_@123@__@PRODCODE@_@123@__@RESDESC@_@123";
            string strItem = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@VATNO@_@123@__@VBELN@_@123@__@CORPCODE@_@123";
            //string strItem = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@VATNO@_@123@__@VBELN@_@123@__@CORPCODE@_@123";
            CONTRACT_INVOICE_RESULTService agent = new CONTRACT_INVOICE_RESULTService();
            if (agent.CreateService())
            {
                var mes = agent.Test_CONTRACT_INVOICE_RESULT(strHeader, strItem);
                MessageBox.Show(mes.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string strItem = "INVOICEITEM@_@123@__@RESDESC@_@123";
            string strHeader = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@VBELN@_@123";
            //string strItem = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@VATNO@_@123@__@VBELN@_@123@__@CORPCODE@_@123";
            CONTRACT_PAID_RESULTService agent = new CONTRACT_PAID_RESULTService();
            if (agent.CreateService())
            {
                var mes = agent.TEST_CONTRACT_PAID_RESULT(strHeader, strItem);
                MessageBox.Show(mes.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string strHeader = "ITEMNO@_@123@__@RESDESC@_@123";
            string strItem = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@EBELN@_@123";

            //string strItem = "RESDESC@_@123@__@MSGID@_@123@__@RESTIME@_@123@__@RESULT@_@123@__@STRSYSNUMBER@_@QH5800@__@VATNO@_@123@__@VBELN@_@123@__@CORPCODE@_@123";
            PAY_CONTRACT_RESPService agent = new PAY_CONTRACT_RESPService();
            if (agent.CreateService())
            {
                var mes = agent.TEST_PAY_CONTRACT_RESP(strHeader, strItem);
                MessageBox.Show(mes.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msgHeadstr = "MANDT@_@111@__@GUID@_@111@__@PROXY_ID@_@111@__@SYSTEM_ID@_@111@__@OPERATOR@_@111@__@SPRAS@_@111@__@INTERFACE_ID@_@111@__@SENDER@_@111@__@RECIVER@_@111@__@SENDTIME@_@111";
            string respHeadstr = "ZZXXH@_@111@__@ZZYL8@_@111@__@ZZYL7@_@111@__@ZZYL6@_@111@__@ZZYL5@_@111@__@ZZYL4@_@111@__@ZZYL3@_@111@__@ZZYL2@_@111@__@ZZYL1@_@111@__@ZZXTBS@_@111@__@ZZEPECSN@_@111@__@ZZEPECLN@_@111@__@ZZEPECID@_@111@__@ZZCLSJ@_@111@__@ZZCLRQ@_@111@__@LOGSYS@_@QH5800@__@EBELN@_@111";
            EPEC_ORDER_APP_RESPService agent = new EPEC_ORDER_APP_RESPService();
            if (agent.CreateService())
            {
                var mes = agent.TEST_EPEC_ORDER_APP_RESP(msgHeadstr, respHeadstr);
                MessageBox.Show(mes.ToString());

            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ZMROSDZCSMIGOHstr = "MSGID@_@111@__@LOGSYS@_@TR4800@__@ZIDECDDH@_@111@__@ZIDECKEY@_@111@__@ZIDECNAME@_@111@__@EBELN@_@111@__@ZBZ@_@111@__@RESERVE1@_@111@__@RESERVE2@_@111@__@RESERVE3@_@111@__@RESERVE4@_@111@__@RESERVE5@_@111@__@RESERVE6@_@111@__@RESERVE7@_@111@__@RESERVE8@_@111";
            string ZMROSDZCSMIGOLstr = "ZIDECKJXY@_@111@__@ZIDECDDH@_@111@__@ZIDECDDHXMH@_@111@__@EBELN@_@111@__@EBELP@_@111@__@ZDHQR@_@111@__@ERFMG@_@111@__@ERFME@_@111@__@ZBZ@_@111@__@ZYL1@_@111@__@ZYL2@_@111@__@ZYL3@_@111@__@ZYL4@_@111@__@ZYL5@_@111@__@ZYL6@_@111@__@ZYL7@_@111@__@ZYL8@_@111";
            IDEC_EMARKET_PO_CONFIRMService agent = new IDEC_EMARKET_PO_CONFIRMService();
            if (agent.CreateService())
            {
                var mes = agent.TEST_IDEC_EMARKET(ZMROSDZCSMIGOHstr, ZMROSDZCSMIGOLstr);
                MessageBox.Show(mes.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错");
            }

        }
    }
}

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
    public partial class hlhuang : Form
    {
        public hlhuang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string itemStr = "MSGID@_@122@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@ZHKWYH@_@122@__@BIDCONSIGN@_@122@__@BIDFILECODE@_@122";
            WZERP_E_BUSINESS.UserService.BID_PAYBACKService agent = new WZERP_E_BUSINESS.UserService.BID_PAYBACKService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_BID_PAYBACK(itemStr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string headStr = "MSGID@_@112@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@REFUNDREQNUM@_@112@__@BIDCONSIGN@_@112@__@BIDFILECODE@_@112";
            string itemStr = "LINEITEM @_@122@__@PACKCODE@_@122@__@AMOUNT@_@122@__@PAYEDMONEY@_@122@__@REMARK@_@122";
            string item1Str = "VOUCHERNO@_@133@__@VOUCHERYEAR@_@133";
            WZERP_E_BUSINESS.UserService.BID_REFUNDService agent = new WZERP_E_BUSINESS.UserService.BID_REFUNDService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_BID_REFUND(headStr, itemStr, item1Str);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string itemStr = "MSGID@_@144@__@SYSNUMER@_@QH5800@__@COMPANY@_@peitc@__@TRANSNUM@_@144@__@BIDCONSIGN@_@144@__@BIDFILECODE@_@144";
            WZERP_E_BUSINESS.UserService.BID_TRANSFERService agent = new WZERP_E_BUSINESS.UserService.BID_TRANSFERService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_BID_TRANSFER(itemStr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }
    }
}

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

namespace E_BUSINESS_WIN
{
    public partial class yhleng : Form
    {
        public yhleng()
        {
            InitializeComponent();
        }

        //EC反馈采购总额处理结果到物装ERP服务接口定义(yhleng)
        private void button1_Click(object sender, EventArgs e)
        {
            string itemStr = "MSGID@_@123@__@STRSYSNUMBER@_@QH5800@__@STRMONTH@_@123@__@STANDCODE@_@123@__@RESULT@_@123@__@RESDESC@_@123";
            WZERP_E_BUSINESS.UserService.PURCHASE_AMOUNTService agent = new WZERP_E_BUSINESS.UserService.PURCHASE_AMOUNTService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_PURCHASH_AMOUNT(itemStr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        //EC采购方案到物装ERP集成接口服务接口定义
        private void button2_Click(object sender, EventArgs e)
        {
            string headStr = "MSGID@_@1@__@STRSYSNUMBER@_@QH5800@__@BUSINESSTYPE@_@2@__@R_NO@_@3@__@BUKRS@_@4@__@PURORG@_@5@__@ERFQ_NO@_@6@__@BEDAT@_@7@__@AGDAT@_@8@__@CGFS@_@9@__@ERFQ_TOPIC@_@10@__@STRMEMNAME@_@11@__@DASENDTIME@_@12@__@";//"STRSYSNUMBER@_@QH5800";
            string item1Str = "VENDOR_NO@_@14@__@ERDAT@_@15@__@ZZB@_@16@__@STRENQUTYPE@_@17@__@STRURL@_@18@__@";
            string itemStr = "PR_NO@_@20@__@PRICE@_@21@__@TRANSPORT_FEE@_@22@__@OTHER_FEE@_@23@__@CGLX@_@24@__@STRTAX@_@25@__@INTQTY@_@26@__@ZCGBZ@_@27@__@STRORDERCODE@_@28@__@DACONTIME@_@29@__@";

            
            WZERP_E_BUSINESS.UserService.STOCK_AFFRIMService agent = new WZERP_E_BUSINESS.UserService.STOCK_AFFRIMService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_STOCKE_AFFRIM(headStr, itemStr, item1Str);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }
        }

        //EC采购委托到物装ERP集成接口服务接口定义
        private void button3_Click(object sender, EventArgs e)
        {
            string headStr = "MSGID@_@123@__@STRSYSNUMBER@_@QH5800@__@BUSINESSTYPE@_@123";
            string itemStr = "STRORDERCODE@_@123@__@PZWT_NO@_@123";
            WZERP_E_BUSINESS.UserService.STOCK_AUTHORIZEService agent = new WZERP_E_BUSINESS.UserService.STOCK_AUTHORIZEService();
            if (agent.CreateService())
            {
                var result = agent.TEST_STOCK_AUTHORIZE(headStr, itemStr);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("CreateService Error!!!!");
            }
        }

        //
        private void button4_Click(object sender, EventArgs e)
        {
            string headstr = "ITEMNO@_@123@__@STOCKORDER@_@QH5800@__@SUPPCODE@_@123";
            string itemStr = "MSGID@_@123@__@STRN@_@QH5800@__@COMPCODE@_@123@__@COMPORG@_@123@__@STOCKAFFIRM@_@QH5800@__@SENDTIME@_@123";
            WZERP_E_BUSINESS.UserService.ZQ_IF002Service agent = new WZERP_E_BUSINESS.UserService.ZQ_IF002Service();
            if (agent.CreateService())
            {
                var result = agent.TEST_ZQ_IF002(headstr, itemStr);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("CreateService Error!!!!");
            }
        }

        //易派客反馈合同关闭状态处理结果接口
        private void button5_Click(object sender, EventArgs e)
        {
            string msgHeadstr = "MANDT@_@111@__@GUID@_@111@__@PROXY_ID@_@111@__@SYSTEM_ID@_@111@__@OPERATOR@_@111@__@SPRAS@_@111@__@INTERFACE_ID@_@111@__@SENDER@_@111@__@RECIVER@_@111@__@SENDTIME@_@111";
            string respHeadstr = "ZZXXH@_@111@__@ZZYL8@_@111@__@ZZYL7@_@111@__@ZZYL6@_@111@__@ZZYL5@_@111@__@ZZYL4@_@111@__@ZZYL3@_@111@__@ZZYL2@_@111@__@ZZYL1@_@111@__@ZZXTBS@_@111@__@ZZEPECSN@_@111@__@ZZEPECLN@_@111@__@ZZEPECID@_@111@__@ZZCLSJ@_@111@__@ZZCLRQ@_@111@__@LOGSYS@_@111@__@EBELN@_@111";
            WZERP_E_BUSINESS.UserService.SI_EPEC_ORDER_CLOSE_RESPService agent = new WZERP_E_BUSINESS.UserService.SI_EPEC_ORDER_CLOSE_RESPService();
            if (agent.CreateService())
            {
                var result = agent.Test_Epec_Close(msgHeadstr, respHeadstr);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("服务创建失败！");
            }
        }
    }
}

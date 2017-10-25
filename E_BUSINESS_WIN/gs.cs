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
    public partial class gs : Form
    {
        public gs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EC5.0购进合同传输到物装ERP服务接口定义
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string REQTstr = "MSGID@_@1@__@STRSYSNUMBER@_@QH5800@__@PONO@_@1@__@ECPONO@_@1@__@SUPPCODE@_@1@__@VENDORCODE@_@1@__@CORPCODE@_@1@__@CORPCODEN4@_@1@__@ERPGROUP@_@1@__@CREATEUSER@_@1@__@INTPFZC@_@1@__@DASUBTIME@_@1@__@KONNR@_@1@__@ATTRTYPE@_@1@__@STOCKTYPE@_@1@__@ENQUTYPE@_@1@__@CREATEDATE@_@1@__@ISPO@_@1@__@OUTPORT@_@1@__@ARRIVEPORT@_@1@__@DOWNLOADDATE@_@1@__@IFLAG@_@1";
            string CONTRACTCONTRACTMATstr = "ECORDERCODE@_@1@__@CORPCODE@_@1@__@PRODCODE@_@1@__@PRNO@_@1@__@PRODDESC@_@1@__@INTQTY@_@1@__@INTPRICE@_@1@__@INTFREE@_@1@__@INTOTHER@_@1@__@SAVEAMOUNT@_@1@__@TAXCODE@_@1@__@INTAVGPRICE@_@1@__@UNIT@_@3@__@CONTADD@_@1@__@TECHSTANDARD@_@1";
            WZERP_E_BUSINESS.UserService.HT_CONTRACT_REQService agent = new WZERP_E_BUSINESS.UserService.HT_CONTRACT_REQService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_REQ(REQTstr, CONTRACTCONTRACTMATstr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }



        }

        /// <summary>
        /// EC5.0物流合同传输到物装ERP服务接口定义
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {

            string CONTRACTWLstr = "MSGID@_@123@__@STRSYSNUMBER@_@QH5800@__@PONO@_@123@__@ECPONO@_@123@__@SUPPCODE@_@123@__@VENDORCODE@_@123@__@CORPCODE@_@123@__@CORPCODEN4@_@123@__@ERPGROU@_@123@__@CREATEUSER@_@123@__@DASUBTIME@_@123@__@KONNR@_@123@__@STOCKTYPE@_@123@__@TOTALSAVEAMOUNT@_@123@__@CREATEDATE@_@123@__@OUTPORT@_@123@__@ARRIVEPORT@_@123@__@DOWNLOADDATE@_@123@__@IFLAG@_@123";
            string CONTRACTWLCONTRACTWLMATstr = "PRNO@_@123@__@ECORDERCODE@_@123@__@PRODCODE@_@123@__@YFBZ@_@123@__@YFHL@_@123@__@DASTARTDATE@_@123@__@DAENDDATE@_@123@__@GWZXF@_@123@__@GWGKFY@_@123@__@GWBGBJ@_@123@__@GWLYF@_@123@__@GWHYF@_@123@__@GWKYF@_@123@__@GWQTFY@_@123@__@GWFYBZ@_@123@__@GNBGBJ@_@123@__@GNGKFY@_@123@__@GNCXF@_@123@__@GNLYF@_@123@__@GNSYF@_@123@__@GNKYF@_@123@__@GNQTFY@_@123@__@GNFYBZ@_@123@__@INTTAX@_@123@__@INTAVGPRICE@_@123@__@ENQUTYPE@_@123@__@TECHSTANDARD@_@123";
            WZERP_E_BUSINESS.UserService.HT_LOGISTICS_CONTRACTService agent = new WZERP_E_BUSINESS.UserService.HT_LOGISTICS_CONTRACTService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_LOGISTICS_CONTRACT(CONTRACTWLstr, CONTRACTWLCONTRACTWLMATstr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }




        }


        /// <summary>
        /// 物装ERP已关闭合同信息传输到EC5.0处理结果反馈服务接口定义
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            string RESULTstr = "MSGID@_@144@__@RESDESC@_@144@__@RESTIME@_@144@__@RESULT@_@144@__@STRSYSNUMBER@_@QH5800@__@VBELN@_@144";
            string CONTRACTITEMRESULTstr = "INVOICEITEM@_@144@__@RESDESC@_@13";
            WZERP_E_BUSINESS.UserService.HT_CONTRACT_CLOSED_RESULTService agent  = new WZERP_E_BUSINESS.UserService.HT_CONTRACT_CLOSED_RESULTService();
            if (agent.CreateService())
            {
                string invokeStr = agent.TEST_CLOSED_RESULT(RESULTstr, CONTRACTITEMRESULTstr);
                MessageBox.Show(invokeStr.ToString());
            }
            else
            {
                MessageBox.Show("创建服务出错！");
            }



        }

        
    }
}

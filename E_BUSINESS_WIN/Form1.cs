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

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yhleng yh = new yhleng();
            yh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ccye ye = new ccye();
            ye.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            xpli li = new xpli();
            li.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gs g = new gs();
            g.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hlhuang huang = new hlhuang();
            huang.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xychen chen = new xychen();
            chen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            xqhu hu = new xqhu();
            hu.Show();
        }
    }
     
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class transreceipt : Form
    {
        public transreceipt()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void transreceipt_Load(object sender, EventArgs e)
        {
            Label5.Text = DateTime.Now.ToString();
            lbldate.Text = DateTime.Now.ToString();
        }
    }
}

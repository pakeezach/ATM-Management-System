using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace ATM
{
    public partial class Login_frm : Form
    {

        public Login_frm()
        {
            InitializeComponent();
        }


        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
        System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
        DataSet dset = new DataSet();
        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Mainmenu fm = new Mainmenu();
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void llbreg_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Regs_frm fm = new Regs_frm();
                fm.Show();
        }
    }
}

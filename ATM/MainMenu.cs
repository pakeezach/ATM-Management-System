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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }


        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
        System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
        DataSet dset = new DataSet();
        System.Data.OleDb.OleDbConnection con= new System.Data.OleDb.OleDbConnection();
        string sql;

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            llbldate.Text =DateTime.Now.ToString();
            //llblname.Text = name.ToString();
        }

        private void btndep_Click(object sender, EventArgs e)
        {
            Deposit fm = new Deposit();
            fm.Show();
        }

        private void BalanceInq_Click(object sender, EventArgs e)
        {
           transreceipt fm = new transreceipt();
            fm.Show();
        }

        private void btnwith_Click(object sender, EventArgs e)
        {
            Withdraw fm = new Withdraw();
            fm.Show();
        }
    }
}

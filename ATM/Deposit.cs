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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {
           
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
        }
    }
}

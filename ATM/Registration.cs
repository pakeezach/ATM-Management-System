using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ATM
{
    public partial class Regs_frm : Form
    {




        public Regs_frm()
        {

            constr = "   Provider=haier-pc\\sqlexpress.project.dbo; Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Pooling=False";
            conn = new System.Data.OleDb.OleDbConnection(constr);

            InitializeComponent();
        }

        
        string constr;
        
        System.Data.OleDb.OleDbDataAdapter adapt1 = new System.Data.OleDb.OleDbDataAdapter();

        System.Data.OleDb.OleDbConnection conn;


        DataSet dset = new DataSet();
       

        public static object Default { get; internal set; }

        private void Form2_Load(object sender, EventArgs e)
        {

            conn.ConnectionString = constr;
            conn.Open();
        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAcctNo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(System.Object sender, EventArgs e)
        {

            if (txtAcctNo.Text == "" && txtPincode.Text == "" && txtcontact.Text == "" && txtfname.Text == "" && txtaddr.Text == "" && txtcontact
                .Text == "" && cbGender.Text == "" && cbday.Text == "" && cbmonth.Text == "" && cbyear.Text == "")
            {

                MessageBox.Show(" Enter All Fields");
            }
            else if (txtAcctNo.Text == "" || txtPincode.Text == "" || txtcontact.Text == "" || txtfname.Text == "" || txtlname.Text == ""
                || txtaddr.Text == "" || txtcontact.Text == "" || cbGender.Text == "" || cbday.Text == "" || cbmonth.Text == "" || cbyear.Text == "")
            {
                MessageBox.Show(" Pls complete all Fields");

            }
            else
            {

                System.Data.OleDb.OleDbDataAdapter adapt1 = new System.Data.OleDb.OleDbDataAdapter
                    ("select * from tblinfo where Firstname=\'" + txtfname.Text + "\'", conn);
                DataSet dset1 = new DataSet();
                adapt1.Fill(dset1);
                if (dset1.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Account name already exist");

                }

                else
                {
                    string dbcommand = " INSERT into tblinfo( account_no, Firstname, Lastname, Address, Contact_no , Birthday, pin_code , type, balance)" +
                      " VALUES(\'" + (txtAcctNo.Text + " \' , \'") + txtfname.Text + " \' , \'" + txtlname.Text + " \' , \'" + txtcontact.Text
                      + " \' , \'" + cbGender.Text + " \' , \'" + (cbmonth.Text + cbday.Text + cbyear.Text) + "\' , \'" + txtPincode.Text
                      + "\' , \'" + "Active" + "\' , \'" + " 1000" + "\'  )";
                    System.Data.OleDb.OleDbDataAdapter adapt = new System.Data.OleDb.OleDbDataAdapter(dbcommand, conn);
                    DataSet dset = new DataSet();
                    adapt.Fill(dset);
                    MessageBox.Show(" You Have Succefully Registered!");
                    this.Hide();
                    Login_frm fm = new Login_frm();
                    fm.Show();


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace ATM
{
    partial class Mainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnwith = new System.Windows.Forms.Button();
            this.BalanceInq = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnlogout = new System.Windows.Forms.Button();
            this.llbldate = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.llblname = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblaccno = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.btnwith);
            this.GroupBox1.Controls.Add(this.BalanceInq);
            this.GroupBox1.Controls.Add(this.btndep);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(50, 142);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(541, 263);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Transaction";
            // 
            // btnwith
            // 
            this.btnwith.BackColor = System.Drawing.Color.Firebrick;
            this.btnwith.Location = new System.Drawing.Point(153, 159);
            this.btnwith.Name = "btnwith";
            this.btnwith.Size = new System.Drawing.Size(162, 71);
            this.btnwith.TabIndex = 2;
            this.btnwith.Text = "Withdraw";
            this.btnwith.UseVisualStyleBackColor = false;
            this.btnwith.Click += new System.EventHandler(this.btnwith_Click);
            // 
            // BalanceInq
            // 
            this.BalanceInq.BackColor = System.Drawing.Color.Firebrick;
            this.BalanceInq.Location = new System.Drawing.Point(38, 53);
            this.BalanceInq.Name = "BalanceInq";
            this.BalanceInq.Size = new System.Drawing.Size(162, 70);
            this.BalanceInq.TabIndex = 0;
            this.BalanceInq.Text = "Balance Inq.";
            this.BalanceInq.UseVisualStyleBackColor = false;
            this.BalanceInq.Click += new System.EventHandler(this.BalanceInq_Click);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.Firebrick;
            this.btndep.Location = new System.Drawing.Point(286, 53);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(158, 70);
            this.btndep.TabIndex = 1;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(439, 87);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(152, 33);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // llbldate
            // 
            this.llbldate.AutoSize = true;
            this.llbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbldate.ForeColor = System.Drawing.Color.White;
            this.llbldate.Location = new System.Drawing.Point(436, 18);
            this.llbldate.Name = "llbldate";
            this.llbldate.Size = new System.Drawing.Size(53, 24);
            this.llbldate.TabIndex = 4;
            this.llbldate.Text = "Date:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(64, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 25);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Hello!!";
            // 
            // llblname
            // 
            this.llblname.AutoSize = true;
            this.llblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblname.ForeColor = System.Drawing.Color.White;
            this.llblname.Location = new System.Drawing.Point(155, 46);
            this.llblname.Name = "llblname";
            this.llblname.Size = new System.Drawing.Size(0, 25);
            this.llblname.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(64, 95);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(135, 25);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Account No: ";
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.ForeColor = System.Drawing.Color.White;
            this.lblaccno.Location = new System.Drawing.Point(205, 104);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(42, 25);
            this.lblaccno.TabIndex = 8;
            this.lblaccno.Text = "no.";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.llblname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.llbldate);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Mainmenu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label llbldate;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label llblname;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lblaccno;
        public System.Windows.Forms.Button BalanceInq;
        public System.Windows.Forms.Button btnwith;
        public System.Windows.Forms.Button btndep;
    }
}
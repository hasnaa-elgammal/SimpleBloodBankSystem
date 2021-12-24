namespace A_life
{
    partial class AddDonationForm
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.danations_lbl = new System.Windows.Forms.Label();
            this.adddonation = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOODORDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.nationalnum = new System.Windows.Forms.Label();
            this.mobile_num = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.Label();
            this.mobilenum_txt = new System.Windows.Forms.TextBox();
            this.nationalnum_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.adddonation);
            this.mainpanel.Controls.Add(this.menu);
            this.mainpanel.Controls.Add(this.tableLayoutPanel1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1407, 662);
            this.mainpanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.danations_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 75);
            this.panel1.TabIndex = 22;
            // 
            // danations_lbl
            // 
            this.danations_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.danations_lbl.AutoSize = true;
            this.danations_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.danations_lbl.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danations_lbl.ForeColor = System.Drawing.Color.White;
            this.danations_lbl.Location = new System.Drawing.Point(471, 9);
            this.danations_lbl.Name = "danations_lbl";
            this.danations_lbl.Size = new System.Drawing.Size(353, 59);
            this.danations_lbl.TabIndex = 20;
            this.danations_lbl.Text = "Add Donation";
            this.danations_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adddonation
            // 
            this.adddonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.adddonation.FlatAppearance.BorderSize = 0;
            this.adddonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddonation.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddonation.ForeColor = System.Drawing.Color.Black;
            this.adddonation.Location = new System.Drawing.Point(542, 530);
            this.adddonation.Name = "adddonation";
            this.adddonation.Size = new System.Drawing.Size(534, 60);
            this.adddonation.TabIndex = 11;
            this.adddonation.Text = "Add Blood Donation";
            this.adddonation.UseVisualStyleBackColor = false;
            this.adddonation.Click += new System.EventHandler(this.adddonation_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.dONATIONSToolStripMenuItem,
            this.bLOODORDERSToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 80, 8, 80);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(183, 662);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hOMEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // dONATIONSToolStripMenuItem
            // 
            this.dONATIONSToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dONATIONSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dONATIONSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.dONATIONSToolStripMenuItem.Name = "dONATIONSToolStripMenuItem";
            this.dONATIONSToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.dONATIONSToolStripMenuItem.Text = "DONATIONS";
            this.dONATIONSToolStripMenuItem.Click += new System.EventHandler(this.dONATIONSToolStripMenuItem_Click);
            // 
            // bLOODORDERSToolStripMenuItem
            // 
            this.bLOODORDERSToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLOODORDERSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bLOODORDERSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.bLOODORDERSToolStripMenuItem.Name = "bLOODORDERSToolStripMenuItem";
            this.bLOODORDERSToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.bLOODORDERSToolStripMenuItem.Text = "ORDERS";
            this.bLOODORDERSToolStripMenuItem.Click += new System.EventHandler(this.bLOODORDERSToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.usersToolStripMenuItem.Text = "USERS";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.firstname_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastname, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nationalnum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mobile_num, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.city, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bloodgroup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mobilenum_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nationalnum_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastname_txt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.city_txt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(231, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 323);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // firstname_txt
            // 
            this.firstname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstname_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_txt.Location = new System.Drawing.Point(256, 3);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(316, 42);
            this.firstname_txt.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(578, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(166, 35);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Last Name:";
            // 
            // nationalnum
            // 
            this.nationalnum.AutoSize = true;
            this.nationalnum.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalnum.Location = new System.Drawing.Point(3, 107);
            this.nationalnum.Name = "nationalnum";
            this.nationalnum.Size = new System.Drawing.Size(247, 35);
            this.nationalnum.TabIndex = 3;
            this.nationalnum.Text = "National Number:";
            // 
            // mobile_num
            // 
            this.mobile_num.AutoSize = true;
            this.mobile_num.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_num.Location = new System.Drawing.Point(3, 214);
            this.mobile_num.Name = "mobile_num";
            this.mobile_num.Size = new System.Drawing.Size(226, 35);
            this.mobile_num.TabIndex = 4;
            this.mobile_num.Text = "Mobile Number:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(578, 107);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(75, 35);
            this.city.TabIndex = 6;
            this.city.Text = "City:";
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSize = true;
            this.bloodgroup.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodgroup.Location = new System.Drawing.Point(578, 214);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(190, 35);
            this.bloodgroup.TabIndex = 5;
            this.bloodgroup.Text = "Blood Group:";
            // 
            // mobilenum_txt
            // 
            this.mobilenum_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mobilenum_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenum_txt.Location = new System.Drawing.Point(256, 217);
            this.mobilenum_txt.MaxLength = 11;
            this.mobilenum_txt.Name = "mobilenum_txt";
            this.mobilenum_txt.Size = new System.Drawing.Size(316, 42);
            this.mobilenum_txt.TabIndex = 9;
            // 
            // nationalnum_txt
            // 
            this.nationalnum_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nationalnum_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalnum_txt.Location = new System.Drawing.Point(256, 110);
            this.nationalnum_txt.MaxLength = 14;
            this.nationalnum_txt.Name = "nationalnum_txt";
            this.nationalnum_txt.Size = new System.Drawing.Size(316, 42);
            this.nationalnum_txt.TabIndex = 10;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastname_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_txt.Location = new System.Drawing.Point(831, 3);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(317, 42);
            this.lastname_txt.TabIndex = 11;
            // 
            // city_txt
            // 
            this.city_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.city_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_txt.Location = new System.Drawing.Point(831, 110);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(317, 42);
            this.city_txt.TabIndex = 13;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(3, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(168, 35);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 18F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox1.Location = new System.Drawing.Point(831, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 43);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddDonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1407, 662);
            this.Controls.Add(this.mainpanel);
            this.Name = "AddDonationForm";
            this.Text = "Add Donation";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label nationalnum;
        private System.Windows.Forms.Label mobile_num;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label bloodgroup;
        private System.Windows.Forms.TextBox mobilenum_txt;
        private System.Windows.Forms.TextBox nationalnum_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOODORDERSToolStripMenuItem;
        private System.Windows.Forms.Button adddonation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label danations_lbl;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}
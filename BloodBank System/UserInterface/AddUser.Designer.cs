namespace A_life.UserInterface
{
    partial class AddUser
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOODORDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.danations_lbl = new System.Windows.Forms.Label();
            this.adddonation = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(183, 653);
            this.menu.TabIndex = 20;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.danations_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 75);
            this.panel1.TabIndex = 23;
            // 
            // danations_lbl
            // 
            this.danations_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.danations_lbl.AutoSize = true;
            this.danations_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.danations_lbl.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danations_lbl.ForeColor = System.Drawing.Color.White;
            this.danations_lbl.Location = new System.Drawing.Point(483, 9);
            this.danations_lbl.Name = "danations_lbl";
            this.danations_lbl.Size = new System.Drawing.Size(364, 59);
            this.danations_lbl.TabIndex = 20;
            this.danations_lbl.Text = "Add New User";
            this.danations_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adddonation
            // 
            this.adddonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.adddonation.FlatAppearance.BorderSize = 0;
            this.adddonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddonation.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddonation.ForeColor = System.Drawing.Color.Black;
            this.adddonation.Location = new System.Drawing.Point(559, 533);
            this.adddonation.Name = "adddonation";
            this.adddonation.Size = new System.Drawing.Size(534, 60);
            this.adddonation.TabIndex = 25;
            this.adddonation.Text = "Add User";
            this.adddonation.UseVisualStyleBackColor = false;
            this.adddonation.Click += new System.EventHandler(this.adddonation_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.username, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.password, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.username_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastname_txt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.password_txt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 323);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // firstname_txt
            // 
            this.firstname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstname_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_txt.Location = new System.Drawing.Point(256, 3);
            this.firstname_txt.MaxLength = 25;
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
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 161);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(165, 35);
            this.username.TabIndex = 3;
            this.username.Text = "UserName:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(578, 161);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(153, 35);
            this.password.TabIndex = 6;
            this.password.Text = "Password:";
            // 
            // username_txt
            // 
            this.username_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(256, 164);
            this.username_txt.MaxLength = 25;
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(316, 42);
            this.username_txt.TabIndex = 10;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastname_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_txt.Location = new System.Drawing.Point(831, 3);
            this.lastname_txt.MaxLength = 25;
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(317, 42);
            this.lastname_txt.TabIndex = 11;
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(831, 164);
            this.password_txt.MaxLength = 25;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(317, 42);
            this.password_txt.TabIndex = 13;
            this.password_txt.UseSystemPasswordChar = true;
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 653);
            this.Controls.Add(this.adddonation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOODORDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label danations_lbl;
        private System.Windows.Forms.Button adddonation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label firstname;
    }
}
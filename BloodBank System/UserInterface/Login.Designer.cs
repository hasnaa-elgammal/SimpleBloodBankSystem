namespace A_life.UserInterface
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.login_btn);
            this.mainpanel.Controls.Add(this.tableLayoutPanel1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(882, 503);
            this.mainpanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.danations_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 75);
            this.panel1.TabIndex = 22;
            // 
            // danations_lbl
            // 
            this.danations_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.danations_lbl.AutoSize = true;
            this.danations_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.danations_lbl.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danations_lbl.ForeColor = System.Drawing.Color.White;
            this.danations_lbl.Location = new System.Drawing.Point(358, 9);
            this.danations_lbl.Name = "danations_lbl";
            this.danations_lbl.Size = new System.Drawing.Size(162, 59);
            this.danations_lbl.TabIndex = 20;
            this.danations_lbl.Text = "Login";
            this.danations_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(348, 352);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(201, 60);
            this.login_btn.TabIndex = 11;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.username_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.password_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.username, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 145);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 159);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // username_txt
            // 
            this.username_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(321, 3);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(400, 42);
            this.username_txt.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(3, 79);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(153, 35);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(321, 82);
            this.password_txt.MaxLength = 25;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(400, 42);
            this.password_txt.TabIndex = 10;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(165, 35);
            this.username.TabIndex = 0;
            this.username.Text = "UserName:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(150, 185);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label danations_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label username;
    }
}
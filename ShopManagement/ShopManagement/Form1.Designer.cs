namespace ShopManagement
{
    partial class Form1
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
            BAL.LoginClass loginClass1 = new BAL.LoginClass();
            DAL.DataBaseClass dataBaseClass1 = new DAL.DataBaseClass();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UI = new System.Windows.Forms.Panel();
            this.employeeHome1 = new ShopManagement.EmployeeHome();
            this.managerHome1 = new ShopManagement.ManagerHome();
            this.registrationPanel1 = new ShopManagement.RegistrationPanel();
            this.loginPanel1 = new ShopManagement.LoginPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.UI.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.UI);
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 738);
            this.panel1.TabIndex = 0;
            // 
            // UI
            // 
            this.UI.Controls.Add(this.employeeHome1);
            this.UI.Controls.Add(this.managerHome1);
            this.UI.Controls.Add(this.registrationPanel1);
            this.UI.Controls.Add(this.loginPanel1);
            this.UI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI.Location = new System.Drawing.Point(0, 33);
            this.UI.Margin = new System.Windows.Forms.Padding(4);
            this.UI.Name = "UI";
            this.UI.Size = new System.Drawing.Size(1200, 705);
            this.UI.TabIndex = 1;
            // 
            // employeeHome1
            // 
            this.employeeHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeHome1.Location = new System.Drawing.Point(0, 0);
            this.employeeHome1.MainForm = null;
            this.employeeHome1.Name = "employeeHome1";
            this.employeeHome1.Size = new System.Drawing.Size(1200, 705);
            this.employeeHome1.TabIndex = 3;
            this.employeeHome1.Username = "Welcome, username";
            // 
            // managerHome1
            // 
            this.managerHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerHome1.Location = new System.Drawing.Point(0, 0);
            this.managerHome1.MainForm = null;
            this.managerHome1.Name = "managerHome1";
            this.managerHome1.Size = new System.Drawing.Size(1200, 705);
            this.managerHome1.TabIndex = 2;
            this.managerHome1.UserLabel = "Welcome, username";
            // 
            // registrationPanel1
            // 
            this.registrationPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.registrationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationPanel1.Location = new System.Drawing.Point(0, 0);
            this.registrationPanel1.MainForm = null;
            this.registrationPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.registrationPanel1.Name = "registrationPanel1";
            this.registrationPanel1.Size = new System.Drawing.Size(1200, 705);
            this.registrationPanel1.TabIndex = 1;
            // 
            // loginPanel1
            // 
            this.loginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.loginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginPanel1.Location = new System.Drawing.Point(0, 0);
            dataBaseClass1.Conn = null;
            dataBaseClass1.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass1.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass1.Password = "@A123456";
            dataBaseClass1.ServerName = "sql5045.site4now.net";
            dataBaseClass1.UserName = "DB_A4C9FB_AlaBro_admin";
            loginClass1.Database = dataBaseClass1;
            loginClass1.UserData = null;
            this.loginPanel1.LoginBAL = loginClass1;
            this.loginPanel1.MainForm = null;
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(1200, 705);
            this.loginPanel1.TabIndex = 0;
            this.loginPanel1.Load += new System.EventHandler(this.loginPanel1_Load);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.button2);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1200, 33);
            this.MenuPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1099, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1150, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "m";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.UI.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UI;
        private RegistrationPanel registrationPanel1;
        private LoginPanel loginPanel1;
        private ManagerHome managerHome1;
        private EmployeeHome employeeHome1;
    }
}


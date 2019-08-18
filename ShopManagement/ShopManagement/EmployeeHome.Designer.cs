namespace ShopManagement
{
    partial class EmployeeHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BAL.DataClass dataClass7 = new BAL.DataClass();
            DAL.DataBaseClass dataBaseClass7 = new DAL.DataBaseClass();
            BAL.DataClass dataClass8 = new BAL.DataClass();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            DAL.DataBaseClass dataBaseClass8 = new DAL.DataBaseClass();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProduct1 = new ShopManagement.AddProduct();
            this.sellProduct1 = new ShopManagement.SellProduct();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 738);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sell product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sellProduct1);
            this.panel2.Controls.Add(this.addProduct1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 738);
            this.panel2.TabIndex = 4;
            // 
            // addProduct1
            // 
            dataClass7.Data = null;
            dataBaseClass7.Conn = null;
            dataBaseClass7.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass7.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass7.Password = "@A123456";
            dataBaseClass7.ServerName = "sql5045.site4now.net";
            dataBaseClass7.UserName = "DB_A4C9FB_AlaBro_admin";
            dataClass7.DB = dataBaseClass7;
            this.addProduct1.DataBAL = dataClass7;
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(0, 0);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(985, 738);
            this.addProduct1.TabIndex = 0;
            // 
            // sellProduct1
            // 
            dataBaseClass8.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass8.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass8.Password = "@A123456";
            dataBaseClass8.ServerName = "sql5045.site4now.net";
            dataBaseClass8.UserName = "DB_A4C9FB_AlaBro_admin";
            dataClass8.DB = dataBaseClass8;
            this.sellProduct1.DataBAL = dataClass8;
            this.sellProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellProduct1.Location = new System.Drawing.Point(0, 0);
            this.sellProduct1.Name = "sellProduct1";
            this.sellProduct1.PresentQuantity = 0;
            this.sellProduct1.Size = new System.Drawing.Size(985, 738);
            this.sellProduct1.TabIndex = 1;
            this.sellProduct1.TotalPrice = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Home";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(5, 65);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(137, 17);
            this.userName.TabIndex = 10;
            this.userName.Text = "Welcome, username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeHome";
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private SellProduct sellProduct1;
        private AddProduct addProduct1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button button1;
    }
}

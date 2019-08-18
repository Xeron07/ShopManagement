namespace ShopManagement
{
    partial class ManagerHome
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
            BAL.DataClass dataClass4 = new BAL.DataClass();
            DAL.DataBaseClass dataBaseClass6 = new DAL.DataBaseClass();
            BAL.DataClass dataClass5 = new BAL.DataClass();
            DAL.DataBaseClass dataBaseClass7 = new DAL.DataBaseClass();
            BAL.DataClass dataClass6 = new BAL.DataClass();
            DAL.DataBaseClass dataBaseClass8 = new DAL.DataBaseClass();
            BAL.ProductData productData2 = new BAL.ProductData();
            DAL.DataBaseClass dataBaseClass9 = new DAL.DataBaseClass();
            BAL.EmployeeBAL employeeBAL2 = new BAL.EmployeeBAL();
            DAL.DataBaseClass dataBaseClass4 = new DAL.DataBaseClass();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProduct1 = new ShopManagement.AddProduct();
            this.sellProduct1 = new ShopManagement.SellProduct();
            this.viewCustomer1 = new ShopManagement.ViewCustomer();
            this.viewProduct1 = new ShopManagement.ViewProduct();
            this.viewEmployee1 = new ShopManagement.ViewEmployee();
            this.updateInformation1 = new ShopManagement.UpdateInformation();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sell Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "My Information";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 548);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "LogOut";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 738);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Manager Home";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(-1, 55);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(137, 17);
            this.userName.TabIndex = 8;
            this.userName.Text = "Welcome, username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateInformation1);
            this.panel2.Controls.Add(this.addProduct1);
            this.panel2.Controls.Add(this.sellProduct1);
            this.panel2.Controls.Add(this.viewCustomer1);
            this.panel2.Controls.Add(this.viewProduct1);
            this.panel2.Controls.Add(this.viewEmployee1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 738);
            this.panel2.TabIndex = 9;
            // 
            // addProduct1
            // 
            dataClass4.Data = null;
            dataBaseClass6.Conn = null;
            dataBaseClass6.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass6.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass6.Password = "@A123456";
            dataBaseClass6.ServerName = "sql5045.site4now.net";
            dataBaseClass6.UserName = "DB_A4C9FB_AlaBro_admin";
            dataClass4.DB = dataBaseClass6;
            this.addProduct1.DataBAL = dataClass4;
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(0, 0);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(1012, 738);
            this.addProduct1.TabIndex = 11;
            // 
            // sellProduct1
            // 
            dataClass5.Data = null;
            dataBaseClass7.Conn = null;
            dataBaseClass7.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass7.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass7.Password = "@A123456";
            dataBaseClass7.ServerName = "sql5045.site4now.net";
            dataBaseClass7.UserName = "DB_A4C9FB_AlaBro_admin";
            dataClass5.DB = dataBaseClass7;
            this.sellProduct1.DataBAL = dataClass5;
            this.sellProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellProduct1.Location = new System.Drawing.Point(0, 0);
            this.sellProduct1.Name = "sellProduct1";
            this.sellProduct1.PresentQuantity = 0;
            this.sellProduct1.Size = new System.Drawing.Size(1012, 738);
            this.sellProduct1.TabIndex = 10;
            this.sellProduct1.TotalPrice = 0;
            // 
            // viewCustomer1
            // 
            dataClass6.Data = null;
            dataBaseClass8.Conn = null;
            dataBaseClass8.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass8.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass8.Password = "@A123456";
            dataBaseClass8.ServerName = "sql5045.site4now.net";
            dataBaseClass8.UserName = "DB_A4C9FB_AlaBro_admin";
            dataClass6.DB = dataBaseClass8;
            this.viewCustomer1.DataBAL = dataClass6;
            this.viewCustomer1.Location = new System.Drawing.Point(0, 0);
            this.viewCustomer1.Name = "viewCustomer1";
            this.viewCustomer1.Size = new System.Drawing.Size(1365, 628);
            this.viewCustomer1.TabIndex = 2;
            // 
            // viewProduct1
            // 
            this.viewProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProduct1.Location = new System.Drawing.Point(0, 0);
            this.viewProduct1.MainPage = null;
            this.viewProduct1.Name = "viewProduct1";
            productData2.Data = null;
            dataBaseClass9.Conn = null;
            dataBaseClass9.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass9.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass9.Password = "@A123456";
            dataBaseClass9.ServerName = "sql5045.site4now.net";
            dataBaseClass9.UserName = "DB_A4C9FB_AlaBro_admin";
            productData2.DB = dataBaseClass9;
            this.viewProduct1.Products = productData2;
            this.viewProduct1.Size = new System.Drawing.Size(1012, 738);
            this.viewProduct1.TabIndex = 1;
            // 
            // viewEmployee1
            // 
            this.viewEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataBaseClass4.Conn = null;
            dataBaseClass4.ConnectionString = "Data Source=sql5045.site4now.net;Initial Catalog=DB_A4C9FB_AlaBro;User ID=DB_A4C9" +
    "FB_AlaBro_admin;Password=@A123456";
            dataBaseClass4.DBName = "DB_A4C9FB_AlaBro";
            dataBaseClass4.Password = "@A123456";
            dataBaseClass4.ServerName = "sql5045.site4now.net";
            dataBaseClass4.UserName = "DB_A4C9FB_AlaBro_admin";
            employeeBAL2.DB = dataBaseClass4;
            this.viewEmployee1.Employeers = employeeBAL2;
            this.viewEmployee1.Location = new System.Drawing.Point(0, 0);
            this.viewEmployee1.Name = "viewEmployee1";
            this.viewEmployee1.Size = new System.Drawing.Size(1012, 738);
            this.viewEmployee1.TabIndex = 0;
            // 
            // updateInformation1
            // 
            this.updateInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateInformation1.Location = new System.Drawing.Point(0, 0);
            this.updateInformation1.Name = "updateInformation1";
            this.updateInformation1.Size = new System.Drawing.Size(1012, 738);
            this.updateInformation1.TabIndex = 12;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerHome";
            this.Size = new System.Drawing.Size(1200, 738);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Panel panel2;
        private ViewEmployee viewEmployee1;
        private ViewProduct viewProduct1;
        private ViewCustomer viewCustomer1;
        private SellProduct sellProduct1;
        private AddProduct addProduct1;
        private UpdateInformation updateInformation1;
    }
}

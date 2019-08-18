using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class ManagerHome : UserControl
    {
        public ManagerHome()
        {
            InitializeComponent();
        }
        public Form1 MainForm{ get; set; }
        public string UserLabel
        {
            get {return this.userName.Text; }
            set { this.userName.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.viewProduct1.GetAllData();
            this.viewProduct1.MainPage = this;
            viewProduct1.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.MainForm.ShowLoginPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.viewEmployee1.BringToFront();
            this.viewEmployee1.GetAllEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewCustomer1.GetAllData();
            viewCustomer1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellProduct1.BringToFront();
        }

        public void ShowAddProductPanel()
        {
            this.addProduct1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.updateInformation1.MainPage = this;
            this.updateInformation1.GetInformation();
            this.updateInformation1.BringToFront();
        }
    }
}

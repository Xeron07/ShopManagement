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
    public partial class EmployeeHome : UserControl
    {
        public Form1 MainForm { get; set; }
        public string Username{ get {return this.userName.Text; } set {this.userName.Text=value; } }
        public EmployeeHome()
        {
            InitializeComponent();
            
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.addProduct1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sellProduct1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MainForm.ShowLoginPanel();
        }
    }
}

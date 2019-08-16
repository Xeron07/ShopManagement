using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginPanel1.MainForm = this;
            loginPanel1.BringToFront();
        }

        public void ShowLoginPanel()
        {
            loginPanel1.MainForm = this;
            loginPanel1.BringToFront();
        }

        public void ShowRegPanel()
        {
            registrationPanel1.MainForm = this;
            registrationPanel1.BringToFront();
        }

        private void loginPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}

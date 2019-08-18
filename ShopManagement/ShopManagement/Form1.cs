using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace ShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public User UserData { get; set; }

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

        public void ShowManagerHome()
        {
            this.managerHome1.UserLabel = "Welcome, " + this.UserData.Name;
            this.managerHome1.MainForm = this;
            this.managerHome1.BringToFront();
        }

        private void loginPanel1_Load(object sender, EventArgs e)
        {

        }
        public void ShowEmployeeHome()
        {
            this.employeeHome1.MainForm = this;
            this.employeeHome1.Username = "Welcome, " + this.UserData.Name;
            this.employeeHome1.BringToFront();
        }
    }
}

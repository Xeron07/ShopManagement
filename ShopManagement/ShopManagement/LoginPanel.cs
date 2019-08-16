using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace ShopManagement
{
    public partial class LoginPanel : UserControl
    {
        public LoginClass LoginBAL { get; set; }
        public LoginPanel()
        {
            InitializeComponent();
            this.LoginBAL = new LoginClass();
            
        }

        public Form1 MainForm{ get; set; }
       
        private void signUp_Click(object sender, EventArgs e)
        {
            MainForm.ShowRegPanel();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            bool x = this.LoginBAL.CheckLogin();

            if (x)
            {
                MessageBox.Show("Connection Successfull");
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}

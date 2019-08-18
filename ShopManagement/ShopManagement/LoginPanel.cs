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
           // bool x = this.LoginBAL.CheckLogin();
            User u = new User()
            {
                Email = this.emailValue.Text.Trim(),
                Password=this.passwordField.Text.Trim()
            };
            if (!String.IsNullOrEmpty(u.Email) && !String.IsNullOrEmpty(u.Password))
            {
                if (this.LoginBAL.CheckLogin(u))
                {
                    if (this.LoginBAL.UserData.Email != null)
                    {
                        MessageBox.Show("Login SuccessFul");
                        this.MainForm.UserData = this.LoginBAL.UserData;
                        if (this.MainForm.UserData.Status.ToLower().Equals("manager"))
                        {
                            this.MainForm.ShowManagerHome();
                        }
                        else
                        {
                            this.MainForm.ShowEmployeeHome();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Email or password", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Connection Error", "Oops!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Give All Data","Oops!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void emailValue_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class RegistrationPanel : UserControl
    {
        public RegistrationPanel()
        {
            InitializeComponent();
        }

        public Form1 MainForm { set; get; }

        private void RegistrationPanel_Load(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            MainForm.ShowLoginPanel();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            User newUser = new User()
            {
                Name=this.userName.Text,
                Address=this.userAddress.Text,
                Email=this.email.Text,
                Password=this.password.Text,
                Gender=this.gender.Text,
                Status=this.status.Text
            };
            RegistrationClass rcs = new RegistrationClass();
            if (rcs.Validation(newUser, this.cPassword.Text))
            {
                bool x=rcs.RegisterUser(newUser);
                if (x)
                {
                    MessageBox.Show("Registration Succesful","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }
            }
            else
            {
                MessageBox.Show("Please Fill up all the field","Oops!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

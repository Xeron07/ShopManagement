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
    public partial class UpdateInformation : UserControl
    {
        public ManagerHome MainPage { get; set; }
        public DataClass DataConnection { get; set; }
        public UpdateInformation()
        {
            InitializeComponent();
            this.DataConnection = new DataClass();
            

        }

        public void GetInformation()
        {
            this.uname.Text = this.MainPage.MainForm.UserData.Name;
            this.pass.Text= this.MainPage.MainForm.UserData.Password;
            this.address.Text= this.MainPage.MainForm.UserData.Address;
            this.email.Text= this.MainPage.MainForm.UserData.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.uname.Text) && !String.IsNullOrEmpty(this.pass.Text) && !String.IsNullOrEmpty(this.address.Text) && !String.IsNullOrEmpty(this.email.Text))
            {
                string sql = String.Format("Update dbo.users set name='{0}', password='{1}',address='{2}',email='{3}'", this.uname.Text, this.pass.Text, this.address.Text, this.email.Text);
                if (this.DataConnection.Operation(sql))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("failed");
                    this.GetInformation();
                }

            }
        }
    }
}

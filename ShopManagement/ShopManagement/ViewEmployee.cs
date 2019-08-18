using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BAL;

namespace ShopManagement
{
    public partial class ViewEmployee : UserControl
    {
        public EmployeeBAL Employeers { get; set; }
        public ViewEmployee()
        {
            InitializeComponent();
            this.Employeers = new EmployeeBAL();
            this.GetAllEmployee();
        }

        public void GetAllEmployee()
        {
            DataTable dt = Employeers.GetAllEmployeeData();
            string[] values = null;
            if (dt != null)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    values = new string[]
                    {
                    row["Id"].ToString(),
                    row["Name"].ToString(),
                    row["Email"].ToString(),
                    row["Address"].ToString()
                    };

                    dataGridView1.Rows.Add(values);
                }
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        public void GetEmployeeByName(string employeeName)
        {
            DataTable dt = this.Employeers.GetEmployeeData(employeeName);
            string[] values = null;
            if (dt != null)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    values = new string[]
                    {
                    row["Id"].ToString(),
                    row["Name"].ToString(),
                    row["Email"].ToString(),
                    row["Address"].ToString()
                    };

                    dataGridView1.Rows.Add(values);
                }
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.GetAllEmployee();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.GetEmployeeByName(this.nameSerachField.Text);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            emailField.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            addressField.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
            nameField.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Employeers.UpdateData(int.Parse(userID.Text), nameField.Text, emailField.Text, addressField.Text))
            {
                MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Update Unsuccesful", "Oops!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Employeers.DeleteUser(int.Parse(userID.Text)))
            {
                MessageBox.Show("Delete Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Delete Unsuccesful", "Oops!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

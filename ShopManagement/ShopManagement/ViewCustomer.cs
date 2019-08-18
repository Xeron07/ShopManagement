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
    public partial class ViewCustomer : UserControl
    {
        public DataClass DataBAL { get; set; }
        public ViewCustomer()
        {
            InitializeComponent();
            this.DataBAL = new DataClass();
            this.GetAllData();
        }

        public void GetAllData()
        {
            string sql = "select * from dbo.customer";
            this.DataBAL.GetData(sql);
            DataTable dt = this.DataBAL.Data;
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
                    row["Phone Number"].ToString()
                    };

                    dataGridView1.Rows.Add(values);
                }
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["phonenumber"].Value.ToString();
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = String.Format("update dbo.customer set [Name]='{0}', [Phone Number]='{1}' where Id={2}", textBox2.Text, textBox4.Text,textBox1.Text);
            if (this.DataBAL.Operation(sql))
            {
                MessageBox.Show("Updated");
                this.GetAllData();
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = String.Format("Delete from dbo.customer where Id={0}", textBox1.Text);
            if (this.DataBAL.Operation(sql))
            {
                MessageBox.Show("Deleted");
                this.GetAllData();
            }
            else
            {
                MessageBox.Show(" failed");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.GetAllData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class ViewProduct : UserControl
    {
        public ManagerHome MainPage{ get; set; }
        public ProductData Products { get; set; }

        public ViewProduct()
        {

            InitializeComponent();
            this.Products = new ProductData();
        }

        public void GetAllData()
        {
            this.Products.Products();
            if (this.Products.Data != null)
            {
                string[] rowData = null;
                dataGridView1.Rows.Clear();
                foreach (DataRow row in this.Products.Data.Rows)
                {
                    rowData = new string[]
                    {
                        row["Id"].ToString(),
                        row["Name"].ToString(),
                        row["Quantity"].ToString(),
                        row["Price"].ToString()
                    };
                    dataGridView1.Rows.Add(rowData);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.GetAllData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.MainPage.ShowAddProductPanel();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.productId.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            this.productName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            this.quantity.Text = dataGridView1.Rows[e.RowIndex].Cells["available"].Value.ToString();
            this.productPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = String.Format("Update dbo.products set Name='{0}', Quantity={1},Price={2} where Id={3}", productName.Text, quantity.Text, productPrice.Text, productId.Text);
            
                if (this.Products.Operation(sql))
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
            string sql = String.Format("Delete from dbo.products where Id={0}", productId.Text);
            if (this.Products.Operation(sql))
            {
                MessageBox.Show("Deleted");
                this.GetAllData();
            }
            else
            {
                MessageBox.Show(" failed");
            }
        }

        public void GetAllDataByName()
        {
            this.Products.ProductsByName(textBox3.Text);
            if (this.Products.Data != null)
            {
                string[] rowData = null;
                dataGridView1.Rows.Clear();
                foreach (DataRow row in this.Products.Data.Rows)
                {
                    rowData = new string[]
                    {
                        row["Id"].ToString(),
                        row["Name"].ToString(),
                        row["Quantity"].ToString(),
                        row["Price"].ToString()
                    };
                    dataGridView1.Rows.Add(rowData);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetAllDataByName();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

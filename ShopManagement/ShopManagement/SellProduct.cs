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
    public partial class SellProduct : UserControl
    {
        public DataClass DataBAL{ get; set; }
        public int PresentQuantity { get; set; }
        public int TotalPrice { get; set; }
        public SellProduct()
        {
            InitializeComponent();
            this.DataBAL = new DataClass();
            this.GetAllProductName();
        }

        public void GetAllProductName()
        {
            string sql = "select * from dbo.products where quantity>0";
            if (this.DataBAL.GetData(sql))
            {

                string[] sources = new string[this.DataBAL.Data.Rows.Count];
                string[] idSources=new string[this.DataBAL.Data.Rows.Count];
                int i = 0;

                foreach(DataRow row in this.DataBAL.Data.Rows)
                {
                    sources[i]=row["Name"].ToString();
                    idSources[i] = row["Id"].ToString();
                    i++;
                }
                var suggestionList = new AutoCompleteStringCollection();
                var idsuggestionList = new AutoCompleteStringCollection();
                suggestionList.AddRange(sources);
                textBox1.AutoCompleteCustomSource = suggestionList;
                idsuggestionList.AddRange(sources);
                textBox4.AutoCompleteCustomSource = idsuggestionList;
            }

        }
        public void AddData(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                textBox1.Text = row["Name"].ToString();
                textBox2.Text = row["Price"].ToString();
                textBox4.Text = row["Id"].ToString();
                textBox5.Text = row["Quantity"].ToString();
            }

            this.PresentQuantity = int.Parse(textBox5.Text);
            textBox6.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                string sql = "select * from dbo.products where id=" + textBox4.Text + "";
                this.DataBAL.GetData(sql);
               
                
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string sql = "select * from dbo.products where name='" + textBox1.Text + "'";
                this.DataBAL.GetData(sql);
                AddData(this.DataBAL.Data);
            }
            else
            {
                MessageBox.Show("Enter Product Id or Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tprice = int.Parse(textBox2.Text) * int.Parse(textBox6.Text);
            dataGridView1.Rows.Add(textBox4.Text, textBox1.Text,this.PresentQuantity.ToString(), textBox6.Text, tprice.ToString());
            this.TotalPrice = 0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                this.TotalPrice += int.Parse(dataGridView1.Rows[i].Cells["price"].Value.ToString());
            }
            label9.Text = this.TotalPrice.ToString();
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button3.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox6.Text))
            {
                int x;
                if(!int.TryParse(textBox6.Text ,out x))
                {
                    MessageBox.Show("Enter valid data", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (x > this.PresentQuantity)
                    {
                        textBox6.Text = "0";
                        MessageBox.Show("Decrease the quantity ", "Out of limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        button1.Enabled = false;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.Rows.Count;
            string sql1 = "Insert into dbo.customer (name,[phone number]) values('" + textBox7.Text + "','" + textBox3.Text + "')";
            string sql2 = "Insert into dbo.transection (description,[total price],date,customer,status) values";
            List<string> productUpdate = new List<string>();
            string description = "";
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                description += "["+dataGridView1.Rows[i].Cells["description"].Value.ToString() + "," + dataGridView1.Rows[i].Cells["available"].Value.ToString() + "," + dataGridView1.Rows[i].Cells["price"].Value.ToString() + "],";
                int q = int.Parse(dataGridView1.Rows[i].Cells["quantity"].Value.ToString()) - int.Parse(dataGridView1.Rows[i].Cells["available"].Value.ToString());

                string updateQuery = "update from dbo.product set Quantity=" + q + " where id=" + dataGridView1.Rows[i].Cells["id"].Value.ToString();
                productUpdate.Add(updateQuery);
            }

            sql2 += String.Format("('{0}',{1},'{2}','{3}','sale')", description, label9.Text, DateTime.Now.ToString("dd-mm-yyy"), textBox7.Text);
            this.DataBAL.Operation(sql2);
            foreach(var val in productUpdate)
            {
                this.DataBAL.Operation(val);
            }
            this.DataBAL.Operation(sql1);
            MessageBox.Show("Sold");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

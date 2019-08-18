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
    public partial class AddProduct : UserControl
    {
        public DataClass DataBAL { get; set; }
        public AddProduct()
        {
            InitializeComponent();
            this.DataBAL = new DataClass();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if(!String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                Product p = new Product()
                {
                    Name = textBox2.Text,
                    Quantuity = int.Parse(textBox4.Text),
                    Price = int.Parse(textBox3.Text)
                };

                string sql = String.Format("insert into dbo.products(name,quantity,price) values('{0}',{1},{2})", p.Name, p.Quantuity, p.Price);
               
                    if (this.DataBAL.Operation(sql))
                {
                    MessageBox.Show("New Product Added");
                  }
                else
                {
                    MessageBox.Show(" failed");
                }
            }
        }
    }
}

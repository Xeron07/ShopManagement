using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class ProductData
    {
        public DataBaseClass DB { get; set; }
        public DataTable Data{ get; set; }
        public ProductData()
        {
            this.DB = new DataBaseClass();
        }
        public bool Products()
        {
            if (this.DB.OpenConnection())
            {
                string sql = "select * from dbo.Products";
                this.Data= this.DB.GetData(sql);
                return this.DB.CloseConnection();
            }
            return false ;
        }

        public bool ProductsByName(string name)
        {
            if (this.DB.OpenConnection())
            {
                string sql = "select * from dbo.Products where Name like '%"+name+"%'";
                this.Data = this.DB.GetData(sql);
                return this.DB.CloseConnection();
            }
            return false;
        }

        public bool Operation(string sql)
        {
            if (this.DB.OpenConnection())
            {
                return this.DB.DBExecution(sql);
            }
            return false;
        }
    }
}

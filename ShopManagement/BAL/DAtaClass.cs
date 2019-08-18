using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DataClass
    {
        public DataBaseClass DB{ get; set; }
        public DataTable Data { get; set; }
        public DataClass()
        {
            this.DB = new DataBaseClass();
        }

        public bool GetData(string sql)
        {
            if (this.DB.OpenConnection())
            {
               this.Data= this.DB.GetData(sql);
                return this.DB.CloseConnection();
            }
            return false;
        }

        public bool Operation( string sql)
        {
            if (this.DB.OpenConnection())
            {
                return this.DB.DBExecution(sql);
            }
            return false;
        }

        
    }
}

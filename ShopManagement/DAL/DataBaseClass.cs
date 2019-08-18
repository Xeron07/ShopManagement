using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataBaseClass: DBConnection
    {
        public bool DBExecution(string sql)
        {
            if (this.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.Conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public DataTable GetData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.Conn);
            

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}

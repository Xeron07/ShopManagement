using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
   public class DBConnection
    {
        public string ConnectionString { get; set; }
        public SqlConnection Conn { get; set; }
        public string ServerName { get; set; }
        public string DBName{ get; set; }
        public string UserName{ get; set; }
        public string Password{ get; set; }

        public DBConnection()
        {
            //this.ServerName = "sql5045.site4now.net";
            //this.DBName = "DB_A4C9FB_AlaBro";
            //this.UserName = "DB_A4C9FB_AlaBro_admin";
            //this.Password = "@A123456";
            //this.ConnectionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", this.ServerName, this.DBName, this.UserName, this.Password);
            this.ConnectionString = "Data Source=DESKTOP-S2FI99O\\ALAUDDINSQL;Initial Catalog=Shop-Management;Integrated Security=True";
        }

        public bool OpenConnection()
        {
            this.Conn = new SqlConnection(this.ConnectionString);

            if (this.Conn.State == System.Data.ConnectionState.Closed)
            {
                try
                { 
                    this.Conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool CloseConnection()
        {
            if (this.Conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    this.Conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}

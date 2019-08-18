using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BAL
{
    public class EmployeeBAL
    {
        public DataBaseClass DB { get; set; }
        public EmployeeBAL()
        {
            this.DB = new DataBaseClass();
        }
        public DataTable GetAllEmployeeData()
        {
            if (this.DB.OpenConnection())
            {
                string sql = "select * from dbo.users where Status='Employee'";
                DataTable dt = this.DB.GetData(sql);
                this.DB.CloseConnection();
                return dt;
            }
            else return null;
        }

        public DataTable GetEmployeeData(string employeeName)
        {
            if (this.DB.OpenConnection())
            {
                string sql = "select * from dbo.users where Status='Employee' and Name like '%"+employeeName+"%'";
                DataTable dt = this.DB.GetData(sql);
                this.DB.CloseConnection();
                return dt;
            }
            else return null;
        }

        public bool UpdateData(int id,string name,string email,string address)
        {
            if (this.DB.OpenConnection())
            {
                string sql = String.Format("update dbo.users set Name='{0}',Email='{1}',Address='{2}' where Id={3}", name, email, address, id);
                Console.WriteLine(sql);
                return this.DB.DBExecution(sql);
               
               
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            if (this.DB.OpenConnection())
            {
                string sql = String.Format("Delete from dbo.users where Id={0}", id);
                return this.DB.DBExecution(sql);
                

            }
            return false;
        }
       
    }
}

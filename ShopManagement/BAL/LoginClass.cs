using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BAL
{
   public class LoginClass
    {
        public DataBaseClass Database { get; set; }
        public User UserData { set; get; }

        public LoginClass()
        {
            this.Database = new DataBaseClass();
        }

        public bool CheckLogin(User u)
        {
            if (this.Database.OpenConnection())
            {
                string sql = String.Format("Select * from dbo.users where Email='{0}' and Password='{1}'", u.Email, u.Password);
                DataTable dt= this.Database.GetData(sql);
                this.UserData = new User();
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UserData.Email = row["Email"].ToString();
                        UserData.Name= row["Name"].ToString();
                        UserData.ID= int.Parse(row["Id"].ToString());
                        UserData.Password= row["Password"].ToString();
                        UserData.Gender= row["Gender"].ToString();
                        UserData.Address= row["Address"].ToString();
                        UserData.Status = row["Status"].ToString();
                    }
                }
                return this.Database.CloseConnection();
            }
            return false;
        }
    }
}

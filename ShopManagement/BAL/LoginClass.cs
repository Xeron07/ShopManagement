using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
   public class LoginClass
    {
        public DBConnection Database { get; set; }

        public LoginClass()
        {
            this.Database = new DBConnection();
        }

        public bool CheckLogin()
        {
            if (this.Database.OpenConnection())
            {
                return this.Database.CloseConnection();
            }
            return false;
        }
    }
}

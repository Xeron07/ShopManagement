using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class RegistrationClass
    {
        public User UserData{ get; set; }

        public string CPassword{ get; set; }

        public bool Validation(User u,string cpass)
        {
            if (u != null)
            {
                if (!String.IsNullOrEmpty(u.Name.Trim()) && !String.IsNullOrEmpty(u.Address.Trim()) && !String.IsNullOrEmpty(u.Email.Trim()) && !String.IsNullOrEmpty(u.Gender.Trim()) && !String.IsNullOrEmpty(u.Password.Trim()) && !String.IsNullOrEmpty(u.Status.Trim()) && !String.IsNullOrEmpty(cpass.Trim()))
                {
                    if (u.Password.Equals(cpass))
                    {
                        return true;
                    }
                }
                
            }
                return false;
        }

        public bool RegisterUser(User u)
        {
            DataBaseClass dbClass = new DataBaseClass();
            string sql = String.Format("INSERT INTO [dbo].[users]([Name],[Email],[Password],[Address] ,[Status] ,[Gender]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",u.Name,u.Email,u.Password,u.Address,u.Status,u.Gender);

            if (dbClass.DBExecution(sql))
            {
                return true;
            }
            return false;
        }
    }
}

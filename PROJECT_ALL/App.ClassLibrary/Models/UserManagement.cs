using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClassLibrary
{
    public class UserManagement
    {
        public bool ValidateLogIn(string UserName, string Password)
        {
            return true;
            SqlConnection conn = new SqlConnection(@"server=DESKTOP-89HQ4RL\SQLEXPRESS;database=EmployeeDB;integrated security=true");
            string query = "select count(*) from LoginInfo where UserName=@uName and Password=@pwd";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@uName", UserName));
            cmd.Parameters.Add(new SqlParameter("@pwd", Password));
            conn.Open();
            int noOfUsers = (int)cmd.ExecuteScalar();
            conn.Close();
            return noOfUsers > 0 ? true : false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Rượu.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }
        private AccountDAO()
        {

        }
        public bool login(string username, string password)
        {
            DataProvider provider = new DataProvider();
            string query = "select * from[dbo].[tblDangNhap] where  TaiKhoan = '" + username + "' and MatKhau = '" + password + "'";
            DataTable result = provider.ExecQuery(query);
            return result.Rows.Count > 0;
        }
    }
}

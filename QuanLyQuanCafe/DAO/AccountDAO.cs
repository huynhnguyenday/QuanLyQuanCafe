using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE userName = N'" + username + "' AND password = N'" + password + "' ";
            object[] parameters = { username, password };

            DataTable result = DataProvider.Instance.ExcuteQuery(query, parameters);

            return result.Rows.Count > 0; // Kiểm tra xem có dòng dữ liệu trả về hay không.
        }

    }
}

﻿using QuanLyQuanCafe.DTO;
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
            string query = "USP_Login @userName , @passWord ";
            object[] parameters = { username, password };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});

            return result.Rows.Count > 0; // Kiểm tra xem có dòng dữ liệu trả về hay không.
        }

        public bool UpdateAccount(string username, string displayname , string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newpassword ", new object[] {username, displayname, pass,newpass});

            return result > 0; // nếu như số dòng được thay đổi mà lớn hơn không là có update thành công
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("Select username, displayname, type from dbo.Account");
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account (userName, displayName, type) VALUES (N'{0}', N'{1}', N'{2}')", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0; //Trả về 1 nếu thành công
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET displayName = N'{1}', Type = N'{2}' WHERE userName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where userName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("Update Account SET password = N'0' where userName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance;  }
            private set { DataProvider.instance = value; } 
        }

        private DataProvider()
        {
            
        }

        private string connectionSTR = "Data Source=LAPTOP-3VKE49FM\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"; //chuỗi để xác định chỗ lấy dữ liệu

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối client tới server, using là giải phóng bộ nhớ
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // câu truy vấn để lấy dữ liệu từ query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); //trung gian lấy dữ liệu

                adapter.Fill(data);

                connection.Close();

            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối client tới server, using là giải phóng bộ nhớ
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // câu truy vấn để lấy dữ liệu từ query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteNonQuery();

                connection.Close();

            }

            return data;
        }

        public object ExcuteScalar(string query, object[] parameter)
        {
            Object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối client tới server, using là giải phóng bộ nhớ
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // câu truy vấn để lấy dữ liệu từ query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data = command.ExecuteScalar(); // thực hiện truy xuất trên query và trả về ô đầu tiên trên bảng kết quả

                connection.Close();

            }

            return data;
        }
    }
}

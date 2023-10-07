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
        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"; //chuỗi để xác định chỗ lấy dữ liệu

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối client tới server, using là giải phóng bộ nhớ
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // câu truy vấn để lấy dữ liệu từ query

                SqlDataAdapter adapter = new SqlDataAdapter(command); //trung gian lấy dữ liệu

                adapter.Fill(data);

                connection.Close();

            }

            return data;
        }
    }
}

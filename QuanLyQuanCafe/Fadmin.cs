using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();

        }

        private void Fadmin_Load(object sender, EventArgs e)
        {
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tcBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOP-MJQ34NOI\\HUYNH;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"; //chuỗi để xác định chỗ lấy dữ liệu
            SqlConnection connection = new SqlConnection(connectionSTR); //kết nối client tới server

            string query = " select * from dbo.Account";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection); // câu truy vấn để lấy dữ liệu

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command); //trung gian lấy dữ liệu

            adapter.Fill(data);

            connection.Close();

            dtgvAccount.DataSource = data;
        }
    }
}
